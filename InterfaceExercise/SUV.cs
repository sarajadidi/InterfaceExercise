using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}
        public double EngineSize { get; set; } = 5;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Explorer";
        public int seatsCount { get; set; } = 7;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Build Ford Tough";
        public bool HasChagngedGears { get; set; }

        public bool HasFoldableSeats { get; set; }

        public bool HasBuildInVaccum { get; set; }


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . . ");
        }
        public void Reverse()
        {
            if (HasChagngedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now  reversing. . . ");
                HasChagngedGears = false;
            }
            else
            {
                Console.WriteLine("Can't Reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChagngedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . . ");
                HasChagngedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChagngedGears = isChanged;
        }
    }
}

