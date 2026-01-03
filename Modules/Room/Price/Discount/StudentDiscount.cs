using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Discount
{
    internal class StudentDiscount : PriceDecorator
    {   
        private readonly float discountAmount;
        public StudentDiscount(IPriceCaculator innerLayer, float discountAmount) : base(innerLayer)
        {
            this.discountAmount = discountAmount;
        }

        public override float caculate()
        {
            return inner.caculate() - discountAmount;
        }
    }
}
