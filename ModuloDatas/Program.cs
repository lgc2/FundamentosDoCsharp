// var data = new DateTime(2020, 10, 12, 13, 25, 37);
var dataUtc = DateTime.UtcNow;
var dataLocal = dataUtc.AddHours(-24);

Console.WriteLine($"essa é a data UTC: {dataUtc}");
Console.WriteLine(dataUtc.Day);
Console.WriteLine($"essa é a data local: {dataLocal}");
Console.WriteLine(dataLocal.Day);