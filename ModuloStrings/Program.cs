using System.Text;

// === StringBuilder  ===
var texto = new StringBuilder();
texto.Append("Este");
texto.Append(" texto");
texto.Append(" é");
texto.Append(" um");
texto.Append(" teste");

texto.ToString();
Console.WriteLine(texto);

/*
// === MANIPULANDO STRINGS ===
var texto = "Este texto é um teste";
Console.WriteLine(texto);
Console.WriteLine(texto.Replace("Este", "eSSe"));

var textoDividido = texto.Split(" ");
foreach (var palavra in textoDividido)
{
    Console.WriteLine(palavra);
}

var textoSubstring = texto.Substring(5, 5);
Console.WriteLine($"Substring: {textoSubstring}");

var texto2 = " Este texto é um teste ";
Console.WriteLine(texto2);
Console.WriteLine(texto2.Trim());
*/

/*
// === MÉTODOS ADICIONAIS ===
var texto = "Este texto é um teste";
Console.WriteLine(texto.ToLower());
Console.WriteLine(texto.ToUpper());
Console.WriteLine(texto.Insert(5, "AQUI "));
Console.WriteLine(texto.Remove(5, 0));
Console.WriteLine(texto.Length);
*/

/*
// === ÍNDICES ===
var texto = "Este texto é um teste ";
Console.WriteLine(texto.IndexOf("um"));
Console.WriteLine(texto.LastIndexOf("s"));
*/

/*
// === EQUALS ===
var texto = "Este texto é um teste ";
Console.WriteLine(texto.Equals("Este texto é um teste ")); // true
Console.WriteLine(texto.Equals("Este texto é um teste")); // false
*/

/*
// ==  StartsWith/EndsWith ===
var texto = "Este texto é um teste ";
Console.WriteLine(texto.StartsWith("Este")); // true
Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true
Console.WriteLine(texto.EndsWith("ste ")); // true
Console.WriteLine(texto.EndsWith("ste")); // false
*/

/*
// === COMPARAÇÃO DE STRINGS ===
var texto = "Testando";
Console.WriteLine(texto.CompareTo("Testando")); // 0
Console.WriteLine(texto.CompareTo("testando")); // 1

var texto2 = "Este é um teste!";
Console.WriteLine(texto2.Contains("teste")); // true
Console.WriteLine(texto2.Contains("Teste")); // false
Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
*/

/*
// === INTERPOLAÇÃO DE STRINGS ===
var price = 10.2;
var texto1 = "O preço do produto é " + price + " apenas na promoção!";
var texto2 = string.Format("O preço do produto é {0} apenas na promoção!", price);
var texto3 = $"O preço do produto é {price} apenas na promoção!";
var texto4 = $@"O preço do produto é \n {price} apenas na promoção!"; // o @ faz com que caracteres especiais sejam ignorados

Console.WriteLine(texto1);
Console.WriteLine(texto2);
Console.WriteLine(texto3);
Console.WriteLine(texto4);
*/

/*
// === GUID ===
var id = Guid.NewGuid(); // gera GUID automaticamente
id = new Guid("ee0a080e-9c69-46bf-abd6-0fae796cdb58"); // atribuí um valor ao GUID. OBS: precisa ser nesse formato

Console.WriteLine(id.ToString().Substring(0, 8));
*/
