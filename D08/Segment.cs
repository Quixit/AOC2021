using System.Collections.Generic;

// 0 abcefg - d is in two of the 
//     -1 cf
// 2 acdeg = does not have both digits found in 1
// 3 acdfg = has both digits found in 1
//     -4 bcdf = g is not in this number and not a
// 5 abdfg = does not have both digits found in 1 (has the digits found in 4 that are one the ones in one)
// 6 abdefg 
//     -7 acf = a is the number not in 1
//     -8 abcdefg
// 9 abcdfg

namespace D08
{
    public class Segment
    {
        public Segment(string source)
        {
            var delimiter = source.Split("|");

            Figures = delimiter[0].Split(" ");
            var values = new List<string>(delimiter[1].Split(" "));
            Map = new string[10];

            var i = 0;
            while (values.Count > 0)
            {
                switch (values[i].Length)
                {
                    case 2:
                        Map[2] = values[i];
                        values.RemoveAt(i);
                        break;
                    case 3:
                        Map[7] = values[i];
                        values.RemoveAt(i);
                        break;
                    case 4:
                        Map[4] = values[i];
                        values.RemoveAt(i);
                        break;
                    case 5:
                        
                        values.RemoveAt(i);
                        break;
                    case 6:
                       
                        values.RemoveAt(i);
                        break;
                    case 7:
                        Map[8] = values[i];
                        values.RemoveAt(i);
                        break;
                        
                }

                i++;
                
                if (i >= values.Count)
                    i = 0;
            }
        }

        public string[] Figures { get; set; }

        public string[] Map { get; set; }
    }
}