//-----------------------------------------------------------------------
// <copyright file="Q143CS.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Q143 Orchard Trees in C#
    /// </summary>
    public static class Q143CS
    {
        public static int GetAnswer(double[] input)
        {
            var floats = input.Select(x => Convert.ToSingle(x)).ToArray();

            Triangle2 area = new Triangle2(new Point2(floats[0], floats[1]), new Point2(floats[2], floats[3]), new Point2(floats[4], floats[5]));
            List<Point2> trees = new List<Point2>();

            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    trees.Add(new Point2(i, j));
                }
            }

            return trees.Where(x => area.IsInside(x)).Count();
        }
    }

    /// <summary>
    /// A 2D Point
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct Point2 : IEquatable<Point2>, IComparable<Point2>, IComparable
    {
        /// <summary>
        /// The x value of the point.
        /// </summary>
        private readonly float x;

        /// <summary>
        /// The y value of the point.
        /// </summary>
        private readonly float y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2"/> struct.
        /// </summary>
        /// <param name="xValue">The x value of the point</param>
        /// <param name="yValue">The y value of the point</param>
        public Point2(float xValue, float yValue)
        {
            this.x = xValue;
            this.y = yValue;
        }

        /// <summary>
        /// Gets the X value.
        /// </summary>
        /// <value>The X value.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X", Justification = "X")]
        public float X
        {
            get
            {
                return this.x;
            }
        }

        /// <summary>
        /// Gets the Y value.
        /// </summary>
        /// <value>The Y value.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y", Justification = "Y")]
        public float Y
        {
            get
            {
                return this.y;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Point2)
            {
                return this.Equals((Point2)obj);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point2"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Point2"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Point2"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Point2 other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return (new
            {
                this.X,
                this.Y
            }).GetHashCode();
        }

        public static bool operator ==(Point2 p1, Point2 p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point2 p1, Point2 p2)
        {
            return !p1.Equals(p2);
        }

        /// <summary>
        /// Compares the current instance with another <see cref="System.Object"/> of the same type
        /// and returns an integer that indicates whether the current instance
        /// precedes, follows, or occurs in the same position in the sort order
        /// as the other object.
        /// </summary>
        /// <param name="obj">An <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// Less than zero => This instance precedes other in the sort order.
        /// Zero => This instance occurs in the same position in the sort order as other.
        /// Greater than zero => This instance follows other in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is Point2)
            {
                return this.CompareTo((Point2)obj);
            }
            else
            {
                throw new ArgumentException("Object is not a Point");
            }
        }

        /// <summary>
        /// Compares the current instance with another <see cref="Point2"/>
        /// and returns an integer that indicates whether the current instance
        /// precedes, follows, or occurs in the same position in the sort order
        /// as the other object.
        /// </summary>
        /// <param name="other">An <see cref="Point2"/> to compare with this instance.</param>
        /// <returns>
        /// Less than zero => This instance precedes other in the sort order.
        /// Zero => This instance occurs in the same position in the sort order as other.
        /// Greater than zero => This instance follows other in the sort order.
        /// </returns>
        public int CompareTo(Point2 other)
        {
            if (this.Equals(other))
            {
                return 0;
            }

            if (this.X > other.X)
            {
                return 1;
            }
            else
            {
                if (this.X == other.Y)
                {
                    if (this.Y > other.Y)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }

        public static bool operator >(Point2 p1, Point2 p2)
        {
            return p1.CompareTo(p2) == 1;
        }

        public static bool operator >=(Point2 p1, Point2 p2)
        {
            return p1.Equals(p2) || p1.CompareTo(p2) == 1;
        }

        public static bool operator <(Point2 p1, Point2 p2)
        {
            return p1.CompareTo(p2) == -1;
        }

        public static bool operator <=(Point2 p1, Point2 p2)
        {
            return p1.Equals(p2) || p1.CompareTo(p2) == -1;
        }

        /// <summary>
        /// Get distance between two points.
        /// </summary>
        /// <param name="p1">point 1</param>
        /// <param name="p2">point 2</param>
        /// <returns>The distance</returns>
        public static double GetDistance(Point2 p1, Point2 p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }

    /// <summary>
    /// A 2D Triangle
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct Triangle2 : IEquatable<Triangle2>, IComparable<Triangle2>, IComparable
    {
        /// <summary>
        /// Vertices of triangle
        /// </summary>
        private readonly Point2[] vertices;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2"/> struct.
        /// </summary>
        /// <param name="p1">The first vertex of the triangle.</param>
        /// <param name="p2">The second vertex of the triangle.</param>
        /// <param name="p3">The third vertex of the triangle.</param>
        public Triangle2(Point2 p1, Point2 p2, Point2 p3)
        {
            this.vertices = new Point2[3] { p1, p2, p3 };
        }

        /// <summary>
        /// Gets the first vertex.
        /// </summary>
        /// <value>The Vertex1.</value>
        public Point2 Vertex1
        {
            get
            {
                return this.vertices[0];
            }
        }

        /// <summary>
        /// Gets the second vertex.
        /// </summary>
        /// <value>The Vertex2.</value>
        public Point2 Vertex2
        {
            get
            {
                return this.vertices[1];
            }
        }

        /// <summary>
        /// Gets the third vertex.
        /// </summary>
        /// <value>The Vertex3.</value>
        public Point2 Vertex3
        {
            get
            {
                return this.vertices[2];
            }
        }

        /// <summary>
        /// Check if the specified <see cref="Point2"/> is inside this <see cref="T:Triangle"/> instance (include on edge).
        /// </summary>
        /// <param name="point">The <see cref="Point2"/> which need to check.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Point2"/> is inside the triangle; otherwise, <c>false</c>.
        /// </returns>
        public bool IsInside(Point2 point)
        {
            Vector2 pointToVertex1 = new Vector2(this.vertices[0].X - point.X, this.vertices[0].Y - point.Y);
            Vector2 pointToVertex2 = new Vector2(this.vertices[1].X - point.X, this.vertices[1].Y - point.Y);
            Vector2 pointToVertex3 = new Vector2(this.vertices[2].X - point.X, this.vertices[2].Y - point.Y);

            var vector1To2 = Vector3.Cross(new Vector3(pointToVertex1, 0), new Vector3(pointToVertex2, 0));
            var vector2To3 = Vector3.Cross(new Vector3(pointToVertex2, 0), new Vector3(pointToVertex3, 0));
            var vector3To1 = Vector3.Cross(new Vector3(pointToVertex3, 0), new Vector3(pointToVertex1, 0));

            return (vector1To2.Z <= 0 && vector2To3.Z <= 0 && vector3To1.Z <= 0)
                || (vector1To2.Z >= 0 && vector2To3.Z >= 0 && vector3To1.Z >= 0);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Triangle2)
            {
                return this.Equals((Triangle2)obj);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="Triangle2"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Triangle2"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Triangle2"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Triangle2 other)
        {
            var thisSortedVertices = this.vertices.OrderBy(x => x);
            var otherSortedVertices = other.vertices.OrderBy(x => x);
            return thisSortedVertices.SequenceEqual(otherSortedVertices);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            var thisSortedVertices = this.vertices.OrderBy(x => x).ToList();
            return (new
            {
                v1x = thisSortedVertices[0].X,
                v1y = thisSortedVertices[0].Y,
                v2x = thisSortedVertices[1].X,
                v2y = thisSortedVertices[1].Y,
                v3x = thisSortedVertices[2].X,
                v3y = thisSortedVertices[2].Y
            }).GetHashCode();
        }

        public static bool operator ==(Triangle2 p1, Triangle2 p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Triangle2 p1, Triangle2 p2)
        {
            return !p1.Equals(p2);
        }

        /// <summary>
        /// Compares the current instance with another <see cref="System.Object"/> of the same type
        /// and returns an integer that indicates whether the current instance
        /// precedes, follows, or occurs in the same position in the sort order
        /// as the other object.
        /// </summary>
        /// <param name="obj">An <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// Less than zero => This instance precedes other in the sort order.
        /// Zero => This instance occurs in the same position in the sort order as other.
        /// Greater than zero => This instance follows other in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is Triangle2)
            {
                return this.CompareTo((Triangle2)obj);
            }
            else
            {
                throw new ArgumentException("Object is not a Triangle");
            }
        }

        /// <summary>
        /// Compares the current instance with another <see cref="Triangle2"/>
        /// and returns an integer that indicates whether the current instance
        /// precedes, follows, or occurs in the same position in the sort order
        /// as the other object.
        /// </summary>
        /// <param name="other">An <see cref="Triangle2"/> to compare with this instance.</param>
        /// <returns>
        /// Less than zero => This instance precedes other in the sort order.
        /// Zero => This instance occurs in the same position in the sort order as other.
        /// Greater than zero => This instance follows other in the sort order.
        /// </returns>
        public int CompareTo(Triangle2 other)
        {
            if (this.Equals(other))
            {
                return 0;
            }

            var myA = Point2.GetDistance(this.Vertex1, this.Vertex2);
            var myB = Point2.GetDistance(this.Vertex2, this.Vertex3);
            var myC = Point2.GetDistance(this.Vertex3, this.Vertex1);
            var myS = (myA + myB + myC) / 2;
            var myArea = Math.Sqrt(myS * (myS - myA) * (myS - myB) * (myS - myC));

            var otherA = Point2.GetDistance(other.Vertex1, other.Vertex2);
            var otherB = Point2.GetDistance(other.Vertex2, other.Vertex3);
            var otherC = Point2.GetDistance(other.Vertex3, other.Vertex1);
            var otherS = (otherA + otherB + otherC) / 2;
            var otherArea = Math.Sqrt(otherS * (otherS - otherA) * (otherS - otherB) * (otherS - otherC));

            if (myArea > otherArea)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static bool operator >(Triangle2 p1, Triangle2 p2)
        {
            return p1.CompareTo(p2) == 1;
        }

        public static bool operator >=(Triangle2 p1, Triangle2 p2)
        {
            return p1.Equals(p2) || p1.CompareTo(p2) == 1;
        }

        public static bool operator <(Triangle2 p1, Triangle2 p2)
        {
            return p1.CompareTo(p2) == -1;
        }

        public static bool operator <=(Triangle2 p1, Triangle2 p2)
        {
            return p1.Equals(p2) || p1.CompareTo(p2) == -1;
        }
    }
}