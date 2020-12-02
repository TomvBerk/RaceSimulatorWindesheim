using System;
using System.Collections.Generic;

namespace Model
{
    public class Competition
    {
        public List<Iparticipant> Participants { get; set; }
        public Queue<Track> Tracks { get; set; }

        public Competition(List<Iparticipant> participants, Queue<Track> tracks)
        {
            participants = Participants;
            tracks = Tracks;
        }
        public Track NextTrack()
        {
            try
            {
                return Tracks.Dequeue();
            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }
    }
}
