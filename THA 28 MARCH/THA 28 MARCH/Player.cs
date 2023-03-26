using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace THA_28_MARCH
{
    internal class Player
    {
        public string playerName { get; set; }
        public string playerNum { get; set; }
        public string playerPos { get; set; }
        public Player(string number, string name, string position)
        {
            playerNum = number;
            playerName = name;
            playerPos = position;
        }
        public Player()
        {

        }
    }
}
