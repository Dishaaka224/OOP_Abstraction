using System;
namespace OOP_Abstraction;

abstract class Applience
{
    public abstract string Name { get; }
    public abstract double CalculatePowerConsumption(int hours);
    public void ShowName() => Console.WriteLine(Name);

    public double CalculateWeeklyConsumption(int hoursPerDay)
        => CalculatePowerConsumption(hoursPerDay) * 7;
}
class WashingMachine : Applience
{
    public override string Name => "Washingmachine ";
    public override double CalculatePowerConsumption(int hours) => 1 * hours;
}
class AirHeater : Applience
{
    public override string Name => "Heater";
    public override double CalculatePowerConsumption(int hours) => 2 * hours;
}
class ElectricKettle : Applience
{
    public override string Name => "Water heater";
    public override double CalculatePowerConsumption(int hours) => 1.5 * hours;
}