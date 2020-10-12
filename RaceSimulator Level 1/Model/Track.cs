using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Model
{
    class Track : Section
    {
        public String Name { get; set; }
        public LinkedList<Section> Sections { get; set; }
        Track(String name, SectionTypes[] sections) {
            name = this.Name;
            sections[] = new this.Sections; 
        }
    }
    
}
