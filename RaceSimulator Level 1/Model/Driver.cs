using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Driver : Iparticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Iequipment Equipment { get; set; }
        public TeamColors Teamcolor { get; set; }
    }
}
