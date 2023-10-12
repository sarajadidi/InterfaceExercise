using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int seatsCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Build Ford Tough";
        public bool HasChagngedGears { get; set; }

        public bool HasFourWheelDrive { get; set; }

        public bool HasFlatbed { get; set; }

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . . ");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . . ");
            }
            
        }
        public void Reverse()
        {
            if (HasChagngedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . . ");
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

