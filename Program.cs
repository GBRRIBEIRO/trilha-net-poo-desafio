using DesafioPOO.Models;

Nokia nokia = new Nokia("123", "Tijolão", "000", 200);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Iphone iphone = new Iphone("124", "13", "001", 100);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");
