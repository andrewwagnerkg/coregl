using System;

namespace Infrastructure
{
    public class Vector3D : IEquatable<Vector3D>
    {
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (!ReferenceEquals(this, other)) return false;
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public static bool operator ==(Vector3D a, Vector3D b) => a.Equals(b);

        public static bool operator !=(Vector3D a, Vector3D b) => !a.Equals(b);

        public override string ToString() => $"VECTOR3D {{X:{X}; Y:{Y}; Z:{Z}}}";

        public double Magnitude() => Math.Sqrt(X * X + Y * Y + Z * Z);

        public static Vector3D operator +(Vector3D a, Vector3D b)
            => new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Vector3D operator -(Vector3D a, Vector3D b)
            => new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public static Vector3D operator *(Vector3D a, double phi)
            => new Vector3D(a.X * phi, a.Y * phi, a.Z * phi);

        public bool IsZero => X == 0 && Y == 0 && Z == 0;

        public double Dot(Vector3D a, Vector3D b)
            => a.X * b.X + a.Y * b.Y + a.Z * b.Z;

        public Vector3D Cross(Vector3D a, Vector3D b)
            => new Vector3D(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);

    }
}
