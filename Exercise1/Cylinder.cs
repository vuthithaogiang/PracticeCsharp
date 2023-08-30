using System;

namespace Exercise1
{
    internal class Cylinder
    {

        
        private double Radius { get; set; }
        private double Height { get; set; }

        
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;

            // Call Result method to display results
            Result(BaseArea, LateralArea, TotalArea, Volume);
        }

        // Display results
        private void Result(double baseArea, double lateralArea, double totalArea, double volume)
        {
            Console.WriteLine($"Base Area: {baseArea}");
            Console.WriteLine($"Lateral Area: {lateralArea}");
            Console.WriteLine($"Total Area: {totalArea}");
            Console.WriteLine($"Volume: {volume}");
        }
    }
}
