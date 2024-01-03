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


/*
// === GUID ===
var id = Guid.NewGuid(); // gera GUID automaticamente
id = new Guid("ee0a080e-9c69-46bf-abd6-0fae796cdb58"); // atribuí um valor ao GUID. OBS: precisa ser nesse formato

Console.WriteLine(id.ToString().Substring(0, 8));
*/
