using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Fee
{
    public class ExtraBedFee : PriceExtra
    {
        private readonly int bedNum;
        private readonly float perBedPrice;
        public ExtraBedFee(IPriceCaculator innerLayer, int bedNum, float perBedPrice) : base(innerLayer)
        {
            this.bedNum = bedNum;
            this.perBedPrice = perBedPrice;
        }

        public override float caculate()
        {
            return inner.caculate() + perBedPrice * bedNum;
        }
    }
}
