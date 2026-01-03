using FinalOOP.Modules.Room.Price.Fee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price.BasePrice
{
    public class BasePriceCaculator : IPriceCaculator
    {
        public readonly Room _room;
        public readonly IRoomPriceStrategy _strategy;

        public BasePriceCaculator(Room room, IRoomPriceStrategy strategy)
        {
            _room = room;
            _strategy = strategy;
        }
        public float caculate()
        {
            return _strategy.GetRoomBasePrice(_room);
        }
    }
}
