
using ConsoleDivisionExceptionApp;

public class ExceptionTest
{
  public static void Main()
  {

    int a = 100, b = 0;
    double resultado = 0;
    var app = new ExceptionTest();

    try
    {
      resultado = app.Dividir(a, b);
      Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
     
    }
    finally
    {
      Console.WriteLine("Finalmente a divisão foi finalizada!");
    }

  }

  public double Dividir(int x, int y)
  {
    if (y == 0)
    {
            throw new MyClassException("Minha mensagem customizada de erro!");
    }
    return (x / y);
  }


}

