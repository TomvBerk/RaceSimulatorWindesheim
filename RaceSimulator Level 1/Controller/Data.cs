using Model;
using System.Collections.Generic;

namespace Controller
{
    public static class Data
    {
        public static Competition Competitie { get; set; }
        public static Race CurrentRace { get; set; }

        public static void Initialize()
        {
            List<Iparticipant> Deelnemers = new List<Iparticipant>();
            AddParticipant(Deelnemers);
            Queue<Track> tracks = new Queue<Track>();
            AddTrack(tracks);

            Competition Competitie = new Competition(Deelnemers, tracks);


        }

        public static void AddParticipant(List<Iparticipant> Deelnemers)
        {
            Car RB = new Car(0, 0, 100);
            Driver a1 = new Driver(naam: "Test", points: 0, equipment: RB, teamcolor: 0);
            Driver a2 = new Driver(naam: "Test2", points: 0, equipment: RB, teamcolor: 1);
            Driver a3 = new Driver(naam: "Test3", points: 0, equipment: RB, teamcolor: 3);
            Driver a4 = new Driver(naam: "Test4", points: 0, equipment: RB, teamcolor: 2);
            Deelnemers.Add(a1);
            Deelnemers.Add(a2);
            Deelnemers.Add(a3);
            Deelnemers.Add(a4);
        }
        public static void AddTrack(Queue<Track> Que)
        {
            Track a4 = new Track("Test", sections: null);
            Track a5 = new Track(name: "Test2", sections: null);
            Track a6 = new Track(name: "Test3", sections: null);
            Que.Enqueue(a4);
            Que.Enqueue(a5);
            Que.Enqueue(a6);


        }
        public static void NextRace()
        {
            Track track = Competitie.NextTrack();
            if (track != null)
            {
                CurrentRace = new Race(track, Competitie.Participants);
            }
        }




    }
}


