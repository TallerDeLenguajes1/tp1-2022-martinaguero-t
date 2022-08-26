namespace Problema1;
class Program {

    static void Main(string[] args){

        Console.WriteLine("2) PROBLEMA 1:");
        Console.Write("Ingrese un número entero: ");
        
        int numero;

        Int32.TryParse(Console.ReadLine(), out numero);

        Console.WriteLine($"El cuadrado del número es: {calcularCuadrado(numero)}");

        Console.ReadLine();
    }

    static int calcularCuadrado(int n){
        return n*n;
    }


}