using System;
using System.Reflection.Metadata;
namespace OOP_Abstraction;

interface Iprinter
{
    void Print (string documentName);
    void PrintReview(string documentName);
    void clean();
}
class LaserPrinter : Iprinter
{
    public void Print(string documentName) => Console.WriteLine($"Laser prints quickly : {documentName}");
    public void PrintReview(string documentName) => Console.WriteLine($"Laser printer preview: {documentName}");
    public void Clean () => Console.WriteLine ($" The laser printer was cleaned.");

    void Iprinter.clean()
    {
        
    }
}
class InkjetPrinter : Iprinter
{
    public void Print(string documentName) => Console.WriteLine($"Inkjet prints quickly : {documentName}");
    public void PrintReview(string documentName) => Console.WriteLine($"Inkjet printer preview: {documentName}");
    public void Clean () => Console.WriteLine ($" The Inkjetprinter was cleaned.");

    void Iprinter.clean()
    {
        
    }
}
class ThermalPrinter : Iprinter
{
    public void Print(string documentName) => Console.WriteLine($"Thermalprints quickly : {documentName}");
    public void PrintReview(string documentName) => Console.WriteLine($"Thermal printer preview: {documentName}");
    public void Clean () => Console.WriteLine ($" The Thermal printer was cleaned.");

    void Iprinter.clean()
    {
        
    }
}