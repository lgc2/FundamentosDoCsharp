Console.WriteLine(DateTime.DaysInMonth(2024, 2)); // no C# o mês (Janeiro) começa em 1

var dataBrasil = DateTime.UtcNow.AddHours(-3);
Console.WriteLine(dataBrasil);
Console.WriteLine(dataBrasil.DayOfWeek);
Console.WriteLine($"hoje é fds? {IsWeekend(dataBrasil.DayOfWeek)}");

static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}


/*
var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanosegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanosegundos);

var timeSpanHoraMinutoSegundo = new TimeSpan(17, 11, 7);
Console.WriteLine(timeSpanHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(3, 5, 12, 8, 100);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
*/


/*
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
*/

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