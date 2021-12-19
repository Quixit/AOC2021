using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace D16
{
    class Packet
    {
        public int Version { get; set; }
        public int Type { get; set; }
        public long Value { get; set; }
        public List<Packet> Children { get; set; }

        public long VersionTotal
        {
            get
            {
                return Children.Sum(c => c.VersionTotal) + Version;
            }

        }

        public long Evaluate
        {
            get
            {
                switch (Type)
                {
                    case 0:
                        return Children.Sum(c => c.Evaluate);
                    case 1:
                        var product = 1L;

                        foreach(var child in Children)
                        {
                            product *= child.Evaluate;
                        }
                        
                        return product;
                    case 2:
                        return Children.Min(c => c.Evaluate);
                    case 4:
                        return Value;
                    case 3:
                        return Children.Max(c => c.Evaluate);
                    case 5:
                        return Children[0].Evaluate > Children[1].Evaluate ? 1 : 0;
                    case 6:
                        return Children[0].Evaluate < Children[1].Evaluate ? 1 : 0;
                    case 7:
                        return Children[0].Evaluate == Children[1].Evaluate ? 1 : 0;
                }

                throw new Exception("Invalid Operation");
            }

        }

        public Packet(string header)
        {
            Version = Convert.ToInt32(header.Substring(0,3), 2);
            Type = Convert.ToInt32(header.Substring(3,3), 2);
            Children = new List<Packet>();
        }
        
        public void Decode(ref int i, string input)
        {
            if (Type == 4)
            {
                var value = "";

                while (input[i] == '1')
                {
                    value += input.Substring(i + 1, 4); 

                    i += 5;
                }
                //Get last one, where == '0'
                value += input.Substring(i + 1, 4); 

                i += 5;
        
                Value = Convert.ToInt64(value, 2);
                //No children, done.
            }
            else
            {
                if (input[i] == '0')
                {
                    i++;
                    var length = Convert.ToInt32(input.Substring(i, 15),2);
                    i += 15;

                    var start = i;

                    while (i < (start + length))
                    {
                        var header = input.Substring(i, 6);
                        i += 6; 
                        
                        var current = new Packet(header);
    
                        Children.Add(current);

                        current.Decode(ref i, input);
                    }
                }
                else
                {
                    i++;
                    var quantity = Convert.ToInt32(input.Substring(i, 11), 2);
                    i += 11;

                    var count = 0;
                    
                    while (count < quantity)
                    {
                        var header = input.Substring(i, 6);
                        i += 6; 
                        
                        var current = new Packet(header);
    
                        Children.Add(current);

                        current.Decode(ref i, input);

                        count++;
                    }
                }
            }
        }
    }
}