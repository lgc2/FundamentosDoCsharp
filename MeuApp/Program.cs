namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parametros opcionais de métodos/funções têm sempre que vir por último. Para adicioná-los basta atribuir valor qualquer

            // Value Types armazenam o dado diretamente na memória (Stack)
            // --> built-in, structs, enums

            // Reference Types armazenam o local da memória (Heap)
            // --> Classes, Objects, Arrays
            // --> ao alterar valor de uma variável, afeta todos que estão apontando para aquele local de memória

            var mouse = new Product(1, "Mouse Gamer", 20.75m, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.PriceInDolar(5m));
            Console.WriteLine($"Type is {mouse.Type}");
            Console.WriteLine($"Type is {(int)mouse.Type}");
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public EProductType Type;

        public Product(int id, string name, decimal price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public decimal PriceInDolar(decimal dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
