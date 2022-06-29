using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(AreaRectangle(4, 5));
            // Console.WriteLine(AreaCircle(4));
            // Console.WriteLine(AreaTriangle(10, 9));
            double floorPlanArea = AreaRectangle(1500, 2500) + (0.5 * AreaCircle(375)) + AreaTriangle(750, 500);
            double flooringMaterialCost = 180;
            double totalCost = floorPlanArea * flooringMaterialCost;
            double totalPesos = Math.Round(totalCost, 2);
            Console.WriteLine($"The total cost to floor the required area is {totalPesos} pesos.");
        }

        static double AreaRectangle(double length, double width) {
            return length * width;
        }

        static double AreaCircle(double radius) {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double AreaTriangle(double bottom, double height) {
            return 0.5 * bottom * height;
        }
    }
}