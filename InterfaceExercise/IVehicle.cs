using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        
        public double EngineSize {get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public int seatsCount { get; set; }
        public bool HasChagngedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
    }
}

