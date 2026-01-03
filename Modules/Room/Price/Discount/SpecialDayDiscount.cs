using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.Discount
{
    internal class SpecialDayDiscount : PriceDecorator
    {
        private readonly String dateTime;
        public SpecialDayDiscount(IPriceCaculator innerLayer, String dateTime) : base(innerLayer)
        {
            this.dateTime = dateTime;
        }
        private float getSpecialDayMultiplier(String date, String month)
        {
            // If date equal month, lets say 1-1, 11-11, 2-2,...., discound by 10%
            // If 11-11 or 10-10 discount by 20%
            if (date == month)
            {
                if (date[0] == date[1]) return 0.8F;
                return 0.9F;
            }

            //Nothing special, return 1
            return 1;
            
        }
        private float getSpecialDayFee(String day)
        {
            String[] data = day.Split('/');
            String date = data[0];
            String month = data[1];
            return getSpecialDayMultiplier(date, month);
        }
        public override float caculate()
        {
            return inner.caculate() * getSpecialDayFee(dateTime);
        }
    }
}
