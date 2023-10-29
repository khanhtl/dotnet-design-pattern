using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumbleBikesLibrary
{
    public abstract class BicycleCreator
    {
        public abstract IBicycle CreateProduct(string modelName);

    }
}
