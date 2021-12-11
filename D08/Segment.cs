using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

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

            List<string> figures = new List<string>(delimiter[0].Trim().Split(" "));
            Values = new List<string>(delimiter[1].Trim().Split(" "));
            string?[] map = new string?[] { null, null, null, null, null, null, null, null, null, null };
            Decoder = new Dictionary<string, string>();
            
            var i = 0;
            while (figures.Count > 0)
            {
                switch (figures[i].Length)
                {
                    case 2:
                        map[1] = figures[i];
                        figures.RemoveAt(i);
                        break;
                    case 3:
                        map[7] = figures[i];
                        figures.RemoveAt(i);
                        break;
                    case 4:
                        map[4] = figures[i];
                        figures.RemoveAt(i);
                        break;
                    case 5:
                        if (map[1] != null)
                        {
                            //If this contains both characters of the 1, it has to be 3.
                            if (figures[i].Contains(map[1][0]) && figures[i].Contains(map[1][1]))
                            {
                                map[3] = figures[i];
                                figures.RemoveAt(i);
                            }
                            else //Could be 5 or  2
                            {
                                //Segment c is not in 6, but it is in 1.
                                if (map[6] != null && map[1] != null)
                                {
                                    var c = map[6].Contains(map[1][0]) ? map[1][1] : map[1][0];
                                    
                                    //if the digit contains c, it must be 2.
                                    if (figures[i].Contains(c))
                                    {
                                        map[2] = figures[i];
                                        figures.RemoveAt(i);
                                    }
                                    else //must be 5
                                    {
                                        map[5] = figures[i];
                                        figures.RemoveAt(i);
                                    }
                                }
                            }
                        }
                        break;
                    case 6:
                        if (map[1] != null)
                        {
                            //If this contains both characters of the 1, it can't be 6, it has to be 0 or 9
                            if (figures[i].Contains(map[1][0]) && figures[i].Contains(map[1][1]))
                            {
                                if (map[4] != null)
                                {
                                    //If it has all the lines of 4 it must be 9, because 0 lacks the middle
                                    if (figures[i].Contains(map[4][0]) && figures[i].Contains(map[4][1]) && figures[i].Contains(map[4][2])  && figures[i].Contains(map[4][3]))
                                    {
                                        map[9] = figures[i];
                                        figures.RemoveAt(i);
                                    }
                                    else
                                    {
                                        //If it doesn't fit any of the other requirements, it has to be 0.
                                        map[0] = figures[i];
                                        figures.RemoveAt(i);
                                    }
                                }
                            }
                            else
                            {
                                //It IS 6
                                map[6] = figures[i];
                                figures.RemoveAt(i);
                            }
                        }
                        break;
                    case 7:
                        map[8] = figures[i];
                        figures.RemoveAt(i);
                        break;
                        
                }

                i++;
                
                if (i >= figures.Count)
                    i = 0;
            }
            
            for (var m = 0; m < map.Length; m++)
            {
                Decoder.Add(new String(map[m].OrderBy(o => o).ToArray()), m.ToString().Trim());
            }
        }

        public Dictionary<string, string> Decoder { get; private set; }

        public  List<string> Values { get; private set; }

        public long Decoded {
            get
            {
                var output = new StringBuilder();
                
                foreach (var value in Values)
                {
                    output.Append(Decoder[new string (value.OrderBy(o => o).ToArray())]);
                }

                return Convert.ToInt64(output.ToString());
            }
        }
    }
}