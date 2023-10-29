using BumbleBikesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DallasCreator : BicycleCreator
    {
        public override IBicycle CreateProduct(string modelName)
        {
            return modelName.ToLower() switch
            {
                "hillcrest" => new RoadBike(),
                "big bend" => new Recumbent(),
                _ => throw new Exception("Invalid bicycle model")
            };
        }
    }
}
