using System;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TriangleApp
{
    /// <summary>
    /// Provides helper methods for triangle operations.
    /// </summary>
    public static class TriangleHelper
    {
        /// <summary>
        /// Checks if three sides (a, b, c) can form a valid triangle.
        /// A valid triangle must satisfy:
        ///     a + b > c
        ///     b + c > a
        ///     c + a > b
        /// </summary>
        /// <param name="a">Length of side a.</param>
        /// <param name="b">Length of side b.</param>
        /// <param name="c">Length of side c.</param>
        /// <returns>
        /// True if the three sides can form a valid triangle; otherwise, false.
        /// </returns>
        public static bool IsTriangle(double a, double b, double c)
        {
            // Immediately return false if any side is non-positive
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            // Check the triangle inequality
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
dotnet new sln - o unit - testing -using-dotnet - test

