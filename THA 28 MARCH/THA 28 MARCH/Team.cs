using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_28_MARCH
{
    internal class Team
    {
        public string teamName { get; set; }
        public string teamCountry { get; set; }
        public string teamCity { get; set; }    
        public List <Player> pemain = new List <Player> ();
        public Team (string teamName , string teamCountry , string teamCity)
        {
            this.teamName = teamName;   
            this.teamCountry = teamCountry;
            this.teamCity = teamCity;
        }
            



    }
}
