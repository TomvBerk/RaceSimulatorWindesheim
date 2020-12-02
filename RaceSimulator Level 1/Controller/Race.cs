using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class Race
    {
        public Track Track { get; set; }
        public List<Iparticipant> Participants { get; set; }
        public DateTime StartTime { get; set; }
        private Random _random;
        private Dictionary<Section, SectionData> _positions = new Dictionary<Section, SectionData>();

        public SectionData GetSectionData(Section value1)
        {
            Boolean isValueEr = _positions.ContainsKey(value1);
            if (isValueEr == true)
            {
                SectionData SD = _positions[value1];
                return SD;
            }
            else
            {
                _positions.Add(value1, null);
                SectionData SD = _positions[value1];
                return SD;
            }
        }
        public Race(Track track, List<Iparticipant> participants)
        {
            track = Track;
            participants = Participants;
            _random = new Random(DateTime.Now.Millisecond);
            EquipmentRandomizer(participants, _random);
        }
        public static void EquipmentRandomizer(List<Iparticipant> drivers, Random random)
        {
            for (int x = 0; x <= drivers.Count; x++)
            {
                int shuffle = random.Next();
                drivers[x].Equipment.Quality = shuffle;
                int shuffle2 = random.Next();
                drivers[x].Equipment.Performance = shuffle2;

            }
        }

    }
}

