using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    interface Iparticipant
    {
        public String Name { get; set; }
        public int Points { get; set; }
        public Iequipment Equipment { get; set; }
        public TeamColors Teamcolor { get; set; }
            
    }

    enum TeamColors { 
            Red,
            Green,
            Yellow,
            Grey,
            Blue


    
    }
}
