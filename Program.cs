using DesafioPOO.Models;

Console.WriteLine($"Smartphone Nokia:");
Smartphone nokia = new Nokia(
    "00 - 00000 - 0000", "Modelo 1", "00000-00000-00000-00000", 12);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine($"Smartphone Iphone:");

Smartphone iphone = new Iphone(
    "10 - 10000 - 1000", "Modelo 2", "11111-11111-11111-11111", 10);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
