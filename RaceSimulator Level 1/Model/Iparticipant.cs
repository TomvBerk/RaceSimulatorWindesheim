namespace Model
{
    public interface Iparticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Iequipment Equipment { get; set; }
        public TeamColors Teamcolor { get; set; }

    }

    public enum TeamColors
    {
        Red = 0,
        Green = 1,
        Yellow = 2,
        Grey = 3,
        Blue = 4



    }
}
