using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP.Modules.Room.System
{
    public class IdSystem
    {
        private static IdSystem instance = new IdSystem();
        private int id = 0;
        private IdSystem() { }
        public int getUniqueId()
        {
            return id++;
        } 
        public static IdSystem getInstance()
        {
            return instance;
        }
    }
}
