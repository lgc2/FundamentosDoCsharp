// Value Types --> Array é Tipo de Valor
var primeiro = new int[4];
var segundo = new int[4];

segundo[0] = primeiro[0];

primeiro[0] = 23;

Console.WriteLine(primeiro[0]);
Console.WriteLine(segundo[0]);


/*
var funcionarios = new Funcionario[2];
funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Luiz" };
funcionarios[1] = new Funcionario() { Id = 33579, Nome = "Letícia" };

Console.WriteLine(funcionarios[0]);
Console.WriteLine(funcionarios[0].Id);
Console.WriteLine(funcionarios[0].Nome);

foreach (var funcionario in funcionarios)
{
    Console.WriteLine($"Nome: {funcionario.Nome} | Id: {funcionario.Id}");
}

public struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
*/

/*
var meuArray = new Teste[2];
meuArray[0] = new Teste();

Console.WriteLine(meuArray[0].Id);
Console.WriteLine(meuArray[1].Id);

struct Teste
{
    public int Id { get; set; }
}
*/

/*
// var meuArray = new int[5]; // posso inicializar sem atribuir valores
// meuArray[0] = 12;

var meuArray = new int[5] { 1, 2, 3, 4, 5 };

foreach (var item in meuArray)
{
    Console.WriteLine(item);
}
*/