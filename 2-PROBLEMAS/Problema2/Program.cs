namespace Problema2;
class Program {

    static void Main(string[] args){

        Console.WriteLine("2) PROBLEMA 2:");
        Console.WriteLine("Se calculará la división entre dos números enteros: ");
        
        int dividendo, divisor;

        try
        {
            Console.Write("Ingrese el dividendo: ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El cociente es: {dividendo/divisor}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: ¡no se puede dividir en cero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("¡Error de formato (ingrese un número válido)!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error encontrado: {e.Message}");
        }

        Console.ReadLine();
    }



}
