using System;

namespace HaftaDortKapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Telefon üretmek için 1'e, bilgisayar üretmek için 2'ye basınız...");
                string selection = Console.ReadLine();
                if (selection == "1")
                {
                    Console.WriteLine("Telefon seri numarası:");
                    int serialNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Telefon hakkında açıklama:");
                    string detail = Console.ReadLine();
                    Console.WriteLine("Telefon adı:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Telefonun işletim sistemi:");
                    string operatingSystem = Console.ReadLine();
                    Console.WriteLine("Telefon TR lisanslı mı? (evet için 'e', hayır için herhangi bir tuşa basın):");
                    string trLicense = Console.ReadLine();
                    bool isTRLicensed = false;
                    if (trLicense == "e")
                    {
                        isTRLicensed = true;
                    }
                    DateTime prodDate = DateTime.Now;
                    BaseMachine phone = new Telephone(prodDate, serialNumber, name, detail, operatingSystem, isTRLicensed);
                    phone.LogInfo();
                }
                else if (selection == "2")
                {
                    Console.WriteLine("Bilgisayar seri numarası:");
                    int serialNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bilgisayar hakkında açıklama:");
                    string detail = Console.ReadLine();
                    Console.WriteLine("Bilgisayar adı:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Bilgisayar işletim sistemi:");
                    string operatingSystem = Console.ReadLine();
                    Console.WriteLine("Bluetooth özelliği var mı? (evet için 'e', hayır için herhangi bir tuşa basın):");
                    string bluetooth = Console.ReadLine();
                    bool hasBluetooth = false;
                    if (bluetooth == "e")
                    {
                        hasBluetooth = true;
                    }
                    Console.WriteLine("Bilgisayar USB çıkış adedi (2 veya 4 olmalıdır):");
                    int usbQty = Convert.ToInt32(Console.ReadLine());
                    DateTime prodDate = DateTime.Now;
                    BaseMachine computer = new Computer(prodDate, serialNumber, name, detail, operatingSystem, usbQty, hasBluetooth);
                    computer.LogInfo();
                }

                Console.WriteLine("Ürününüz başarıyla oluşturuldu, yeni ürün oluşturmak için 'e' tuşuna basabilirsiniz " +
                    "ya da çıkmak için herhangi başka bir tuşa basabilirsiniz");
                string newProduct = Console.ReadLine();
                if (newProduct == "e")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
            while (loop);
            Console.WriteLine("Hoşçakalın!");
        }
    }
}
