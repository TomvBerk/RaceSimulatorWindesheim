using Controller;

namespace RaceSimulator_Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Initialize();
            Data.NextRace();
            System.Console.WriteLine(Data.CurrentRace);
        }
    }
}
