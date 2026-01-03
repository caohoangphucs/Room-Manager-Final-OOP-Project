using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.BasePrice
{
    public class VipPrice: IRoomPriceStrategy
    {
        public float GetRoomBasePrice(Room room)
        {
            return room.basePrice * 1.5F;
        }
    }
}
