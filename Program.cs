using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", IMEI: "111111111", Memoria: 64);

nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine ("Smartphone iPhone:");

Smartphone iphone = new Iphone (numero: "4987", modelo: "Modelo 2", IMEI: "222222222", Memoria: 128);

iphone.ReceberLigacao();

iphone. InstalarAplicativo ("Telegram");

