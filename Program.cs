using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia Nokia110 = new Nokia("5199238212", "Nokia 110", "48521054784", 32);
Nokia110.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Iphone iphoneXr = new Iphone("51992329321", "Iphone Xr", "21547852105", 32);
iphoneXr.InstalarAplicativo("Whatsapp");