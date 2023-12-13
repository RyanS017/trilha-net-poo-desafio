using DesafioPOO.Models;

Nokia nokia = new Nokia("11965845236", "Nokia TMJ", "15648745454", 64);
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("Pressione para continuar");
Console.ReadLine();

Iphone iphone = new Iphone("11965845236", "Nokia TMJ", "15648745454", 64);
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine();
nokia.Ligar();
iphone.ReceberLigacao();