using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D19
{
    internal class Location : IEqualityComparer<Location>
    {
        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Z { get; private set; }

        public static Location operator +(Location a, Location b)
            => new Location(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Location operator -(Location a, Location b)
            => new Location(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public Location WithRotation(int rotation)
        {
            switch (rotation)
            {
                case 0:
                    return this;
                case 1:
                    return new Location(-X, -Y, Z);                    
                case 2:
                    return new Location(Y, -X, Z);
                case 3:
                    return new Location(-Y, X, Z);
            }

            throw new NotImplementedException($"Non existant rotation: {rotation}");
        }

        public Location WithDirection(int direction)
        {
            switch (direction)
            {
                case 0:
                    return this;
                case 1:
                    return new Location(X, -Y, -Z);
                case 2:
                    return new Location(X, -Z, Y);
                case 3:
                    return new Location(-X, -Z, -Y);                    
                case 4:
                    return new Location(Y, -Z, -X);
                case 5:
                    return new Location(-Y, -Z, X);
            }

            throw new NotImplementedException($"Non existant direction: {direction}");
        }

        public bool Equals(Location? a, Location? b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public int GetHashCode([DisallowNull] Location obj)
        {
            return obj.X.GetHashCode() ^ obj.Y.GetHashCode() ^ obj.Z.GetHashCode();
        }
    }
}
