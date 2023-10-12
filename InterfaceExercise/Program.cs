using System;
using System.Collections.Generic;
using InterfaceExercise;

var car = new Car();

var truck = new Truck();

var suv = new SUV();

var vehicles = new List<IVehicle>() { car, truck, suv };



foreach (var vehicle in vehicles)
{
    vehicle.Drive();
    vehicle.ChangeGears(true);
    vehicle.Reverse();
    vehicle.ChangeGears(true);
    vehicle.Park();

}


