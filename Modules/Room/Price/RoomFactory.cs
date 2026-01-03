using FinalOOP.Modules.Room.Price.BasePrice;
using FinalOOP.Modules.Room.System;
using FinalOOP.Modules.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.Price
{
    public class RoomFactory
    {
        public RoomFactory() { }
        public Room createRoom(RoomType type)
        {
            if (type == RoomType.STANDARD)
            {
                Room newStandardRoom = new Room(IdSystem.getInstance().getUniqueId(), type, 1200000, 2, 4);
                newStandardRoom.setPriceStrategy(new StandardPrice());
                return newStandardRoom;
            }

            if (type == RoomType.VIP)
            {
                Room vip = new Room(IdSystem.getInstance().getUniqueId(), type, 3000000, 3, 5);
                vip.setPriceStrategy(new VipPrice());
                return vip;
            }

            if (type == RoomType.FAMILY)
            {
                Room family = new Room(IdSystem.getInstance().getUniqueId(), type, 10000000, 4, 8);
                family.setPriceStrategy(new FamilyPrice());
                return family;
            }
            throw new Exception("Factory not support this type of room : " +  type);
        }
    }
}
