using System;
using System.Collections.Generic;

namespace Model
{
    public class Track : Section
    {
        public string Name { get; set; }
        public LinkedList<Section> Sections { get; set; }
        public Track(string name, SectionTypes[] sections)
        {
            LinkedList<Section> List = new LinkedList<Section>();
            List = arraytypesconverter(sections);

            List = this.Sections;
            name = this.Name;
        }
        public LinkedList<Section> arraytypesconverter(SectionTypes[] sectiontypes)
        {
            var result = new LinkedList<Section>();

            foreach (SectionTypes Sectiess in sectiontypes)
            {
                var temp = new Section();
                temp.SectionType = Sectiess;
                result.AddLast(temp);
            }

            return result;

        }
    }
}
