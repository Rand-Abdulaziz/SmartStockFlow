using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSystemCode
{

    public class RFIDTriangulation
    {
        // Class to represent a 2D Point
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// Calculates the position of the RFID tag using triangulation.
        /// </summary>
        /// <param name="scanner1">Position of Scanner 1 (Point)</param>
        /// <param name="distance1">Distance from Scanner 1 to the tag</param>
        /// <param name="scanner2">Position of Scanner 2 (Point)</param>
        /// <param name="distance2">Distance from Scanner 2 to the tag</param>
        /// <param name="scanner3">Position of Scanner 3 (Point)</param>
        /// <param name="distance3">Distance from Scanner 3 to the tag</param>
        /// <returns>The calculated position of the RFID tag (Point)</returns>
        public static Point CalculatePosition(Point scanner1, double distance1, Point scanner2, double distance2, Point scanner3, double distance3)
        {
            // Convert distances to squared values for simplicity
            double d1Sq = Math.Pow(distance1, 2);
            double d2Sq = Math.Pow(distance2, 2);
            double d3Sq = Math.Pow(distance3, 2);

            // Scanner positions
            double x1 = scanner1.X, y1 = scanner1.Y;
            double x2 = scanner2.X, y2 = scanner2.Y;
            double x3 = scanner3.X, y3 = scanner3.Y;

            // Calculating the coordinates of the tag
            double a = 2 * (x2 - x1);
            double b = 2 * (y2 - y1);
            double c = d1Sq - d2Sq - x1 * x1 - y1 * y1 + x2 * x2 + y2 * y2;

            double d = 2 * (x3 - x1);
            double e = 2 * (y3 - y1);
            double f = d1Sq - d3Sq - x1 * x1 - y1 * y1 + x3 * x3 + y3 * y3;

            // Solving for x and y using the system of equations
            double x = (c * e - f * b) / (a * e - d * b);
            double y = (c * d - a * f) / (b * d - a * e);

            return new Point(x, y);
        }
    }
}