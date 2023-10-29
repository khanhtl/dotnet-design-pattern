using BumbleBikesLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumbleBikesLibrary
{
    public interface IBicycle
    {
        public string ModelName { get; set; }
        public int Year { get; }
        public string SerialNumber { get; }
        public BicycleGeometries Geometry { get; set; }
        public BicyclePaintColors Color { get; set; }
        public SuspensionTypes Suspension { get; set; }
        public ManufacturingStatus BuildStatus { get; set; }
        public void Build();
    }
}
