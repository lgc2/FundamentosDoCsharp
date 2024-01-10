var data = DateTime.UtcNow;
var dataBrasil = data.AddHours(-3);

// var dataBrasilFormatada = String.Format("{0:yy}", dataBrasil);
// Console.WriteLine(dataBrasilFormatada);

// var dataBrasilFormatada = String.Format("{0:M}", dataBrasil);
// Console.WriteLine(dataBrasilFormatada);

var dataBrasilFormatada = String.Format("{0:dd/MM/yy HH:mm}", dataBrasil);
Console.WriteLine(dataBrasilFormatada);



/*
// var data = new DateTime(2020, 10, 12, 13, 25, 37);
var dataUtc = DateTime.UtcNow;
var dataLocal = dataUtc.AddHours(-24);

Console.WriteLine($"essa é a data UTC: {dataUtc}");
Console.WriteLine(dataUtc.Day);
Console.WriteLine($"essa é a data local: {dataLocal}");
Console.WriteLine(dataLocal.Day);
*/