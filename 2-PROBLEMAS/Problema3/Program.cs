namespace Problema3;

class Program {

    static void Main(string[] args){

        Console.WriteLine("2) PROBLEMA 3:");

        uint cantKilometros, cantLitros;


        try 
        {
            Console.Write("Ingrese la cantidad de kilómetros recorridos (número entero): ");
            cantKilometros = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de litros consumidos (número entero): ");
            cantLitros = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($"Kilómetros por litro: {cantKilometros/cantLitros}");
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: ingrese un número válido (error de formato)");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: ¡la cantidad de litros consumidos no puede ser cero!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: no se puede trabajar con números de gran magnitud.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        
        Console.ReadLine();
    }


}
