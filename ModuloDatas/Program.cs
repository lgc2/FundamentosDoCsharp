var dataUtc = DateTime.UtcNow;
var timeZoneBrasil = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
var dataBrasil = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timeZoneBrasil);

Console.WriteLine(dataBrasil.ToString("u"));

var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
    Console.WriteLine("--------------");
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezone));
}


/*
using System.Globalization;

var dataBrasil = DateTime.UtcNow.AddHours(-3);
var ptBr = new CultureInfo("pt-BR");
var enUs = new CultureInfo("en-US");

Console.WriteLine(dataBrasil.ToString("D", ptBr));
Console.WriteLine(dataBrasil.ToString("D", enUs));
*/


/*
var data = DateTime.UtcNow;
var dataBrasil = data.AddHours(-3);
DateTime? dataNula = null;

Console.WriteLine(dataBrasil);
Console.WriteLine(dataNula);

if (dataBrasil.Date == DateTime.UtcNow.AddHours(-3).Date)
{
    Console.WriteLine("É igual!!!");
}
*/


/*
var data = DateTime.UtcNow;
var dataBrasil = data.AddHours(-3);

Console.WriteLine(String.Format("{0:D}", dataBrasil));
Console.WriteLine(dataBrasil.ToString("D"));
Console.WriteLine(dataBrasil.ToString("r"));
Console.WriteLine(dataBrasil.ToString("s"));
Console.WriteLine(dataBrasil.ToString("u"));
*/


/*
var data = DateTime.UtcNow;
var dataBrasil = data.AddHours(-3);

// var dataBrasilFormatada = String.Format("{0:yy}", dataBrasil);
// Console.WriteLine(dataBrasilFormatada);

// var dataBrasilFormatada = String.Format("{0:M}", dataBrasil);
// Console.WriteLine(dataBrasilFormatada);

var dataBrasilFormatada = String.Format("{0:dd/MM/yy HH:mm}", dataBrasil);
Console.WriteLine(dataBrasilFormatada);
*/


/*
// var data = new DateTime(2020, 10, 12, 13, 25, 37);
var dataUtc = DateTime.UtcNow;
var dataLocal = dataUtc.AddHours(-24);

Console.WriteLine($"essa é a data UTC: {dataUtc}");
Console.WriteLine(dataUtc.Day);
Console.WriteLine($"essa é a data local: {dataLocal}");
Console.WriteLine(dataLocal.Day);
*/