using BumbleBikesLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BumbleBikesLibrary
{
    public class Bicycle : IBicycle
    {
        public string ModelName { get; set; }
        public int Year { get; }
        public string SerialNumber { get; }
        public BicyclePaintColors Color { get; set; }
        public BicycleGeometries Geometry { get; set; }
        public SuspensionTypes Suspension { get; set; }
        public ManufacturingStatus BuildStatus { get; set; }
        public Bicycle()
        {
            ModelName = string.Empty;
            SerialNumber = Guid.NewGuid().ToString();
            Year = DateTime.Now.Year;
            BuildStatus = ManufacturingStatus.Specified;
        }
        public void Build()
        {
            Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        
            BuildStatus = ManufacturingStatus.FrameManufactured;
            PrintBuildStatus();

            Console.WriteLine($"Painting the frame {Color.ToString()}");
            BuildStatus = ManufacturingStatus.Painted;
            PrintBuildStatus();

            if (Suspension != SuspensionTypes.Hardtail)
            {
                Console.WriteLine($"Mounting the {Suspension.ToString()} suspension.");
          
                BuildStatus = ManufacturingStatus.SuspensionMounted;
                PrintBuildStatus();
            }
            Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!", Year, ModelName, SerialNumber);
        
            BuildStatus = ManufacturingStatus.Complete;
            PrintBuildStatus();
        }

        private void PrintBuildStatus()
        {
            Console.WriteLine($"....{BuildStatus.ToString()}....");
        }
    }
}
