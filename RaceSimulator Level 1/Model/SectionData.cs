namespace Model
{
    public class SectionData
    {
        public Iparticipant Left { get; set; }
        public int DistanceLeft { get; set; }
        public Iparticipant Right { get; set; }
        public int DistanceRight { get; set; }

        public SectionData(Iparticipant DeelnemerLinks, int AfstandLinks, Iparticipant DeelnemerRechts, int AfstandRechts)
        {
            DeelnemerLinks = Left;
            AfstandLinks = DistanceLeft;
            DeelnemerLinks = Right;
            AfstandRechts = DistanceRight;
        }
    }
}
