namespace Ejercicio3;
class Program {

    static int Main(string[] args){

        int numEmpleados = obtenerNumeroEmpleados();
        List<Empleado> empleados = new List<Empleado>();

        try
        {
            for (int i = 0; i < numEmpleados; i++)
            {
                Console.WriteLine("-> Ingrese la información del empleado: ");

                string nombre, apellido, direccion;

                DateTime fechaIngreso, fechaNacimiento;

                double sueldoBase;
                int cantidadHijos = 0;

                DateTime? fechaDivorcio = null;

                Console.WriteLine(" - Nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine(" - Apellido: ");
                apellido = Console.ReadLine();

                Console.WriteLine(" - Direccion: ");
                direccion = Console.ReadLine();

                Console.WriteLine(" - Fecha de nacimiento: ");

                fechaNacimiento = obtenerFecha();

                Console.WriteLine(" - Fecha de ingreso a la empresa: ");

                fechaIngreso = obtenerFecha();

                sueldoBase = obtenerSueldoBase();

                eCivil estadoCivil = obtenerEstadoCivil();

                if(estadoCivil == eCivil.divorciado) {
                    Console.WriteLine(" - Fecha de divorcio: ");
                    fechaDivorcio = obtenerFecha();
                }
                
                if(estadoCivil == eCivil.casado){
                    cantidadHijos = obtenerNumeroHijos();
                }

                TituloUniversitario? titulo = obtenerTitulacion();

                Empleado nuevoEmpleado = new Empleado(nombre,apellido,direccion,fechaNacimiento,estadoCivil,cantidadHijos,fechaIngreso,sueldoBase,fechaDivorcio,titulo);

                empleados.Add(nuevoEmpleado);

            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"Hubo un error: {ex.Message}");
        }

        mostrarInformacionEmpleados(empleados);

        return 0;

    }

    static double obtenerSueldoBase(){
        double sueldoBase = 0;
        do
        {
            try
            {
                Console.Write(" - Ingrese el sueldo base: ");
                sueldoBase = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un valor correcto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: el valor ingresado es muy grande");
            }

        } while (sueldoBase <= 0);

        return sueldoBase;
    }

    static int obtenerNumeroHijos(){
        int numeroHijos = 0;
        do
        {
            try
            {
                Console.Write(" - Ingrese la cantidad de hijos: ");
                numeroHijos = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un valor correcto");
                numeroHijos = -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: el valor ingresado es muy grande");
                numeroHijos = -1;
            }

        } while (numeroHijos < 0);

        return numeroHijos;
    }
    static DateTime obtenerFecha(){
        DateTime fecha = new DateTime();
        bool fechaValida = false;
        string anio, mes, dia;
        do
        {
            try
            {
                Console.Write(" - Año: ");
                anio = Console.ReadLine();
                Console.Write(" - Mes: ");
                mes = Console.ReadLine();
                Console.Write(" - Día: ");
                dia = Console.ReadLine();

                fechaValida = DateTime.TryParse($"{dia}/{mes}/{anio}", out fecha);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("¡Ingrese una fecha válida!");
            }

            if(!fechaValida) Console.WriteLine("¡Ingrese una fecha válida!");
            
        } while (!fechaValida);

        return fecha;
    }
    static void mostrarInformacionEmpleados(List<Empleado> empleados){
        Console.WriteLine("=> LISTADO DE EMPLEADOS: ");
        foreach (var empleado in empleados)
        {
            empleado.mostrarInfoEmpleado();
            Console.WriteLine("\n");
        }
    }
    static eCivil obtenerEstadoCivil(){
        int opcionEstadoCivil = 0;
        do
        {
            try
            {
                Console.WriteLine(" - Estado civil: ");
                Console.WriteLine("  1- Soltero/a");
                Console.WriteLine("  2- Casado/a");
                Console.WriteLine("  3- Divorciado/a");
                opcionEstadoCivil = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un valor correcto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: el valor ingresado es muy grande");
            }

        } while (opcionEstadoCivil < 0 || opcionEstadoCivil >= 3);

        return (eCivil) opcionEstadoCivil;
    }
    
    static TituloUniversitario obtenerTitulacion() {

        bool tieneTitulo = false, cargado = false;

        TituloUniversitario? titulo = null;
        
        do
        {
            try
            {
                Console.WriteLine(" - ¿Tiene titulo universitario? ");

                Console.WriteLine("  0- NO");
                Console.WriteLine("  1- SI");
                tieneTitulo = Convert.ToBoolean(Console.Read());
                cargado = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un valor correcto");
            }

        } while (!cargado);

        if(tieneTitulo){
            
            bool tituloCargado = false;

            do
            {

                try
                {
                    string nombreTitulo, institucion;
                    Console.WriteLine("Ingrese el titulo: ");
                    nombreTitulo = Console.ReadLine();
                    Console.WriteLine("Ingrese la institución: ");
                    institucion = Console.ReadLine();
                    titulo = new TituloUniversitario(nombreTitulo,institucion);
                    tituloCargado = true;
                    
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (!tituloCargado);

        }

        return titulo;

    }
    static int obtenerNumeroEmpleados(){
        int numEmpleados = 0;
        do
        {
            try
            {
                Console.Write("Ingrese el número de empleados a cargar: ");
                numEmpleados = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un valor correcto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: el valor ingresado es muy grande");
            }

        } while (numEmpleados <= 0);
        return numEmpleados;
    }

}
