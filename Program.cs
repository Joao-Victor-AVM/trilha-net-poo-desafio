using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Smartpone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", "16GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando Smartpone Iphone:");
Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");