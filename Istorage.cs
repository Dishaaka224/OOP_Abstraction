using System;
namespace OOP_Abstraction;
interface IstorageInfo
{
    long GetAvailableSpace();
}
interface IStorage : IstorageInfo
{
    void Upload(string fileName);
    void Download(string fileName);
}

class CloudStorage : IStorage
{
    public void Upload(string fileName) => Console.WriteLine($"Uploaded to the {fileName} Cloud");
    public void Download(string fileName) => Console.WriteLine($"Retrieved from {fileName} the Cloud");
    public long GetAvailableSpace() => 500_000_000_000; 
}

class UsbStorage : IStorage
{
    public void Upload(string fileName) => Console.WriteLine($"Uploaded to the  {fileName} USB ");
    public void Download(string fileName) => Console.WriteLine($"retrieved from {fileName} the USB ");
    public long GetAvailableSpace() => 32_000_000_000; 
}

class MemoryCardStorage : IStorage
{
    public void Upload(string fileName) => Console.WriteLine($"Uploaded to the {fileName} memory card");
    public void Download(string fileName) => Console.WriteLine($"Retrieved from the{fileName} memory card");
    public long GetAvailableSpace() => 64_000_000_000; 
}