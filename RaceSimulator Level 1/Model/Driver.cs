namespace Model
{
    public class Driver : Iparticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Iequipment Equipment { get; set; }
        public TeamColors Teamcolor { get; set; }

        public Driver(string naam, int points, Car equipment, int teamcolor)
        {
            naam = this.Name;
            points = this.Points;
            equipment = (Car)this.Equipment;
            teamcolor = (int)Teamcolor;

        }
    }
}
