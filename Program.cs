using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
/*Implementado*/
Iphone i = new Iphone("000000000", "Iphone 16", "1234567890", 256);

Nokia n = new Nokia("11111111111", "Nokia Modelo 1", "0987654321", 256);

Console.WriteLine("Iphone:");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Google Meet");