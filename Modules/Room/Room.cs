using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalOOP.Modules.Types;
using FinalOOP.Modules.Status;
using FinalOOP.Modules.Room.Price.BasePrice;
namespace FinalOOP.Modules.Room
{
        public class Room
        {
            public int id { get; }
            public RoomType type { get; }
            public float basePrice { get; }
            public int baseCapacity { get; }
            public int maxCapacity { get; }
            public RoomState status { get; private set; }
        public Room(int id, RoomType type, float basePrice, int baseCapacity, int maxCapacity)
        {
            this.id = id;
            this.type = type;
            this.basePrice = basePrice;
            this.baseCapacity = baseCapacity;
            this.maxCapacity = maxCapacity;
        }
        private IRoomPriceStrategy _priceStrategy;
        public void setPriceStrategy(IRoomPriceStrategy priceStrategy)
        {
            _priceStrategy = priceStrategy;
        }
        public void describe()
        {
            Console.WriteLine(type.ToString() + " Room | ID: " + id + "| Base Price : " + basePrice + " | Capacity: " + baseCapacity + "| MaxCapacity: " + maxCapacity);
        }

    }
}
