namespace Model
{
    public class Car : Iequipment
    {
        public int Quality { get; set; }
        public int Performance { get; set; }
        public int Speed { get; set; }
        public bool IsBroken { get; set; }

        public Car(int quality, int performance, int speed)
        {
            quality = Quality;
            performance = Performance;
            speed = Speed;
            IsBroken = false;
        }
    }


}
