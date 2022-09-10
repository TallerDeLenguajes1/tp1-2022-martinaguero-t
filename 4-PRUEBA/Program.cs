namespace Punto4;

class Program {

    static int Main(string[] args) {
        
        try
        {
            FA();
            FB();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            /* Esto muestra el StackTrace completo, la excepción ocurrió en la linea 46, 
            fue lanzada hacia el método llamador (FB), que llama a Dividir en la linea 35, y luego la excepción es re-lanzada hacia Main, donde se llama al método FB. */
        }
        return 0;

    }

    static void FA(){
        try
        {
            Dividir(3,3);
        }
        catch (System.Exception)
        {
            throw;
        }
    }


    static void FB(){
        try
        {
            Dividir(3,0);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    static void Dividir(int a, int b){
        try
        {
            int c = a/b;
        }
        catch (DivideByZeroException)
        {
            throw;
        }
    }
}