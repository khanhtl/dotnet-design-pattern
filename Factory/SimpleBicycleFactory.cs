using BumbleBikesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimpleBicycleFactory
    {
        public Bicycle CreateBicycle(string bicycleType)
        {
            Bicycle bikeToBuild;
            switch (bicycleType)
            {
                case "mountainbike":
                    bikeToBuild = new MountainBike();
                    break;
                case "cruiser":
                    bikeToBuild = new Cruiser();
                    break;
                case "recumbent":
                    bikeToBuild = new Recumbent();
                    break;
                case "roadbike":
                    bikeToBuild = new RoadBike();
                    break;
                default:
                    throw new Exception("Unknown bicycle type: " + bicycleType);
            }
            return bikeToBuild;
        }
    }
}
