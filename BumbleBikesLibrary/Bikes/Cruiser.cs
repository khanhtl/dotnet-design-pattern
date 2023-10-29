using BumbleBikesLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumbleBikesLibrary
{
    public class Cruiser : Bicycle
    {
        public Cruiser()
        {
            ModelName = "Galveston Cruiser";
            Suspension = SuspensionTypes.Hardtail;
            Color = BicyclePaintColors.Red;
            Geometry = BicycleGeometries.Upright;
        }
    }
}
