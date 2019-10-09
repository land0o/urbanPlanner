using System;
using System.Collections.Generic;


namespace Planner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Width = 200;
            FiveOneTwoEigth.Depth = 200;
            FiveOneTwoEigth.GetDateConstructed();
            FiveOneTwoEigth.GetBuyer("Leroy");

            Building OneTwentyTwo = new Building("122 Bell Avenue");
            OneTwentyTwo.Stories = 6;
            OneTwentyTwo.Width = 400;
            OneTwentyTwo.Depth = 400;
            OneTwentyTwo.GetDateConstructed();
            OneTwentyTwo.GetBuyer("Jerome");

            Building ThreeHundredPlus = new Building("300 Plus Park");
            ThreeHundredPlus.Stories = 1;
            ThreeHundredPlus.Width = 100;
            ThreeHundredPlus.Depth = 100;
            ThreeHundredPlus.GetDateConstructed();
            ThreeHundredPlus.GetBuyer("Lamar");

            ThreeHundredPlus.GetBuyer("James Holden");
            OneTwentyTwo.GetBuyer("Naomi Nagata");
            FiveOneTwoEigth.GetBuyer("Bobbie Drapper");

            List<Building> city = new List<Building>();
            city.Add(FiveOneTwoEigth);
            city.Add(OneTwentyTwo);
            city.Add(ThreeHundredPlus);

            City TychoStation = new City()
            {
                NameOfCity = "TychoStation",
                YearEstablished = 2120,
                Mayor = "Fred Johnson"
            };

            TychoStation.Buildings.Add(FiveOneTwoEigth);
            TychoStation.Buildings.Add(OneTwentyTwo);
            TychoStation.Buildings.Add(ThreeHundredPlus);

            foreach (Building building in TychoStation.Buildings)
            {
                Console.WriteLine();
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("-----------------");
                Console.WriteLine($"Designed by {building.GetDesigner()}");
                Console.WriteLine($"Built on {building.GetDateConstructed()}");
                Console.WriteLine($"Owned by {building.GetOwner()}");
                Console.WriteLine();
            }

        }
    }
}
