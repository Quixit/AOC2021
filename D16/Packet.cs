using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace D16
{
    public class Packet
    {
        public int Version { get; set; }
        public int Type { get; set; }
        public long Value { get; set; }

        public int LengthType { get; set; }

        public Packet(string header)
        {
            Version = Convert.ToInt32(header.Substring(0,3), 2);
            Type = Convert.ToInt32(header.Substring(3,3), 2);
        }
    }
}