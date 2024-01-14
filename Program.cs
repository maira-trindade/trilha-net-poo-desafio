using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "912345678", modelo: "Modelo 3310", imei: "1234-56-789245-0", 10);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "978945612", modelo: "iPhone 12", imei: "4561-45-457812-9", 120);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Samsung(numero: "987655452", modelo: "Galaxy S23", imei: "7845-12-794613-5", 100);
samsung.Ligar();
samsung.InstalarAplicativo("Waze");
samsung.ReceberLigacao();