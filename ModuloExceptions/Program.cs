using System.Data;

var array = new int[3];

try
{
    // for (var i = 0; i < 10; i++)
    // {
    //     Console.WriteLine(array[i]);
    // }

    // Cadastrar("");
    Cadastrar("64648sadasd");
}
// Sempre do mais específico para o mais genérico
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o índice na lista");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Argumento não pode ser nulo!!!");
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.QuandoAconteceu);
    Console.WriteLine("Exceção customizada");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Opps, algo deu errado!!!");
}
// O finally é sempre executado, independentemente se teve alguma exceção ou não
finally
{
    Console.WriteLine("Chegou ao fim!!!");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
        throw new MinhaException(DateTime.UtcNow.AddHours(-3));
}

public class MinhaException : Exception
{
    public MinhaException(DateTime date)
    {
        QuandoAconteceu = date;
    }

    public DateTime QuandoAconteceu { get; set; }
}