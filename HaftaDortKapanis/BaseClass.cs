using System;

public abstract class BaseMachine //base class created
{
    public DateTime ProdDate { get; set; }
    public int SerialNum { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
    public string OperatingSystem { get; set; }
    public BaseMachine(DateTime prodDate, int serialNum, string name, string detail, string operatingSystem)
    {
        ProdDate = DateTime.Now;
        SerialNum = serialNum;
        Name = name;
        Detail = detail;
        OperatingSystem = operatingSystem;
    }
    public virtual void LogInfo()
    {
        Console.WriteLine($"prod date: {ProdDate}, serial num: {SerialNum}, details: {Detail}, opr sys: {OperatingSystem}");
    }
    public abstract void GetProductName(); //UrunAdiGetir()
}

public class Telephone : BaseMachine //Telephone class uses BaseMachine class
{
    public bool IsTRLicensed { get; set; }
    public Telephone(DateTime prodDate, int serialNum, string name, string detail,
        string operatingSystem, bool isTRLicensed) : base(prodDate, serialNum, name, detail, operatingSystem)
    {
        IsTRLicensed = isTRLicensed;
    }
    public override void LogInfo() //overridden LogInfo method
    {
        Console.WriteLine($"prod date: {ProdDate}, serial num: {SerialNum}, details: {Detail}, opr sys: {OperatingSystem}, " +
            $"TR licence: {IsTRLicensed}");
    }

    public override void GetProductName() //abstract method being implemented for Telephone class
    {
        Console.WriteLine($"Telefonunuzun adı: {Name}");
    }
}

public class Computer : BaseMachine
{
    public int USBQty { get; set; }
    public bool HasBluetooth { get; set; }
    public Computer(DateTime prodDate, int serialNum, string name, string detail, string operatingSystem,
        int usbQty, bool hasBluetooth) : base(prodDate, serialNum, name, detail, operatingSystem)
    {
        if (usbQty != 2 || usbQty != 4)
        {
            Console.WriteLine("USB giriş sayısı 2 ya da 4 olabilir...");
            USBQty = -1;
        }
        else
        {
            USBQty = usbQty;
        }
        HasBluetooth = hasBluetooth;
    }
    public override void LogInfo()
    {
        Console.WriteLine($"prod date: {ProdDate}, serial num: {SerialNum}, details: {Detail}, opr sys: {OperatingSystem}, " +
            $"USB quantity: {USBQty}, has Bluetooth: {HasBluetooth}");
    }
    public override void GetProductName()
    {
        Console.WriteLine($"Bilgisayarınızın adı: {Name}");
    }
}