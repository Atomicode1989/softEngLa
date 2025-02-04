using Xunit;
using TriangleApp;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace TriangleApp.Tests


{
        /// <summary>
        /// Contains tests for the TriangleHelper class.
        /// </summary>
        public class TriangleHelperTests
        {
            /// <summary>
            /// Tests that 3, 4, 5 is recognized as a valid triangle.
            /// </summary>
            [Fact]
            public void IsTriangle_ValidTriangleIntegers_ReturnsTrue()
            {
                // Arrange
                double a = 3, b = 4, c = 5;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.True(result);
            }

            /// <summary>
            /// Tests that sides with decimal values can form a valid triangle.
            /// </summary>
            [Fact]
            public void IsTriangle_ValidTriangleFloats_ReturnsTrue()
            {
                // Arrange
                double a = 2.5, b = 3.5, c = 4.2;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.True(result);
            }

            /// <summary>
            /// Tests that a side of length zero does not form a valid triangle.
            /// </summary>
            [Fact]
            public void IsTriangle_ZeroSide_ReturnsFalse()
            {
                // Arrange
                double a = 0, b = 4, c = 5;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.False(result);
            }

            /// <summary>
            /// Tests that a negative side does not form a valid triangle.
            /// </summary>
            [Fact]
            public void IsTriangle_NegativeSide_ReturnsFalse()
            {
                // Arrange
                double a = -1, b = 2, c = 3;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.False(result);
            }

            /// <summary>
            /// Tests the condition where one side equals the sum of the other two (1, 2, 3).
            /// Should return false, because 1+2=3 is not strictly greater.
            /// </summary>
            [Fact]
            public void IsTriangle_SumOfTwoSidesEqualsThird_ReturnsFalse()
            {
                // Arrange
                double a = 1, b = 2, c = 3;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.False(result);
            }

            /// <summary>
            /// Tests very large side values that still form a valid triangle.
            /// </summary>
            [Fact]
            public void IsTriangle_LargeSides_ReturnsTrue()
            {
                // Arrange
                double a = 100000, b = 100001, c = 200000;

                // Act
                bool result = TriangleHelper.IsTriangle(a, b, c);

                // Assert
                Assert.True(result);
            }

            /// <summary>
            /// Tests boundary conditions near equality. 
            /// 2 + 4 = 6 means strictly not a triangle.
            /// Slightly above the boundary (2.0001, 3.9999, 6.0000) should be valid.
            /// </summary>
            [Fact]
            public void IsTriangle_EdgeCaseNearBoundary()
            {
                // Arrange & Act
                bool exactlyEqualSidesResult = TriangleHelper.IsTriangle(2.0, 4.0, 6.0);
                bool slightlyOverBoundaryResult = TriangleHelper.IsTriangle(2.0001, 3.9999, 6.0);

                // Assert
                Assert.False(exactlyEqualSidesResult);
                Assert.True(slightlyOverBoundaryResult);
            }
        }
    }
