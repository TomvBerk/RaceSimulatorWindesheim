using System.Collections.Generic;

namespace Model
{
    public class Section
    {
        public SectionTypes SectionType { get; set; }
        public Section(SectionTypes sectionTypes)
        {
            sectionTypes = this.SectionType;
        }

        public Section()
        {
        }

        public LinkedList<Section> ArrayTypesConverter(SectionTypes[] sectionTypes)
        {
          LinkedList<Section> SectionsLijst = new LinkedList<Section>();
         for (int x = 0; x == sectionTypes.Length; x++)
         {
            Section a = new Section(sectionTypes[x]);
            SectionsLijst.AddLast(a);


        }
        return SectionsLijst;

        }

    }
}
