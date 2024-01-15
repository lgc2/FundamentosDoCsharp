using System.Globalization;

var valor = 10536.85m;
Console.WriteLine(Math.Round(valor));
Console.WriteLine(Math.Ceiling(valor));
Console.WriteLine(Math.Floor(valor));


/*
var valor = 10536.5m;
Console.WriteLine(valor);
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
*/