using FinalOOP.Modules.Room;
using FinalOOP.Modules.Room.Price;
using FinalOOP.Modules.Types;
using Models;
using System.Runtime.InteropServices;

class RoomManagerMain
{
    static void Main(string[] args)
    {
        RoomFactory roomFactory = new RoomFactory();
        Room A = roomFactory.createRoom(RoomType.VIP);
        Room B = roomFactory.createRoom(RoomType.STANDARD);
        A.describe();
        B.describe();
    }
}
