namespace Problema1;
class Program {

    static void Main(string[] args){

        Console.WriteLine("2) PROBLEMA 1:");
        Console.Write("Ingrese un número entero: ");
        
        int numero;

        try
        {
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El cuadrado del número es: {calcularCuadrado(numero)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("¡Ingrese un número válido (formato incorrecto)!");
        }
        catch(OverflowException)
        {
            Console.WriteLine("¡Ingrese un número válido (error de overflow)!");
        }
        catch(Exception e)
        {
            Console.WriteLine("Error, ingrese un número válido.");
        }

        Console.ReadLine();
    }

    static int calcularCuadrado(int n){
        return n*n;
    }


}