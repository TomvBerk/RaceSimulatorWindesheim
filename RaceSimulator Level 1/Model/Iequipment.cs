using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Model
{
    interface Iequipment
    {
        int Quality { get; set; }
        int Performance { get; set; }
        int Speed { get; set; }
        Boolean IsBroken { get; set; }
        
    }
}
