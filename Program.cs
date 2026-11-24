using System;
namespace OOP_Abstraction;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n1. Media Assets: ");
        MediaAsset[] assets =
        {
            new AudioAsset("Podcast"),
            new VideoAsset("VideoLesson"),
            new PodcastAsset("C# news")
        };

        foreach (var asset in assets)
        {
            asset.ShowTitle();
            Console.WriteLine(asset.GetFormat());
            asset.Play();
            Console.WriteLine();
        }
        Console.WriteLine("\n2. Applience: ");
        Applience[] appliances =
        {
            new WashingMachine(),
            new AirHeater(),
            new ElectricKettle()
        };

        foreach (var a in appliances)
        {
            Console.WriteLine($"{a.Name}: {a.CalculatePowerConsumption(3)} kVt");
            Console.WriteLine($"Haftalik sarf: {a.CalculateWeeklyConsumption(3)} kVt");
        }
        Console.WriteLine("\n3. Istorage: ");
        IStorage[] storages =
        {
            new CloudStorage(),
            new UsbStorage(),
            new MemoryCardStorage()
        };

        foreach (var storage in storages)
        {
            storage.Upload("course.zip");
            storage.Download("course.zip");
            Console.WriteLine($"Bo'sh joy: {storage.GetAvailableSpace()} bayt");
            Console.WriteLine();
        }
        Console.WriteLine("\n4. Iprinter: ");
        Iprinter[] printers =
        {
            new LaserPrinter(),
            new InkjetPrinter(),
            new ThermalPrinter(),
        };
        foreach (var printer in printers)
        {
            printer.PrintReview("Dars-jadvali");
            printer.clean();
            printer.Print("Dars-jadvali");
            Console.WriteLine();
        }
    }
}