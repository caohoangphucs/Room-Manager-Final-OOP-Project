using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Fee
{
    internal class WeekendFee : PriceExtra
    {
        private readonly float weekendFee;
        public WeekendFee(IPriceCaculator innerLayer, float weekendFee) : base(innerLayer)
        {
            this.weekendFee = weekendFee;
        }

        public override float caculate()
        {
            return inner.caculate() + weekendFee;
        }
    }
}
