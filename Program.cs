using DesafioPOO.Models;

Iphone novoIphone = new("99999999", "Galaxi", "123123", 123);
Nokia novoNokia = new("66666666", "Nokia exemplo", "987987987", 987);

novoIphone.Ligar();
novoNokia.Ligar();


novoIphone.ReceberLigacao();
novoNokia.ReceberLigacao();

novoIphone.InstalarAplicativo("Whatsup");
novoNokia.InstalarAplicativo("YouTub");