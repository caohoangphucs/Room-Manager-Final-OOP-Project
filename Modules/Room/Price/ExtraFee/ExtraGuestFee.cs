using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Fee
{
    
    public class ExtraGuestFee : PriceExtra
    {
        private readonly int guestNum;
        private readonly float perGuestFee;

        public ExtraGuestFee(IPriceCaculator innerLayer, int extraGuestNum, float perGuestFee) : base(innerLayer)
        {
            this.guestNum = extraGuestNum;
            this.perGuestFee = perGuestFee;
        }

        public override float caculate()
        {
            // PerGuestFee for first, 1.2F * PerGuestFee for 2 and above
            float fee = perGuestFee + (guestNum - 1) * 1.2F * perGuestFee;
            return inner.caculate() + fee;
        }
    }
}
