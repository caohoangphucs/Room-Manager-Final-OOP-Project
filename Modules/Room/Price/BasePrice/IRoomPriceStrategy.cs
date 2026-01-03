using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.BasePrice
{
    public interface IRoomPriceStrategy
    {
        public float GetRoomBasePrice(Room room);
    }
}
