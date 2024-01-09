using DesafioPOO.Models;

// Implementado
Console.WriteLine("Iphone");

Smartphone iphone = new Iphone("988884444", "Pro Max", "ax21", 128);

Console.WriteLine(iphone.Numero);

iphone.InstalarAplicativo("Facebook");

iphone.Ligar();

Console.WriteLine("Nokia");

Smartphone nokia = new Nokia("933331111", "Super Nova", "agt8", 256);

Console.WriteLine(nokia.Numero);

nokia.InstalarAplicativo("YouTube");

nokia.ReceberLigacao();
