using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Fee
{
    public abstract class PriceExtra : IPriceCaculator
    {
        protected readonly IPriceCaculator inner;
        public PriceExtra(IPriceCaculator innerLayer) {
            inner = innerLayer;
        }

        public abstract float caculate();
    }
}
