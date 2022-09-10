namespace Ejercicio3;
public enum eCivil { soltero, casado, divorciado };
class Empleado {

    private string nombre;
    private string apellido;
    private string direccion;
    private DateTime fechaIngreso;
    private DateTime fechaNacimiento;
    private double sueldoBase;
    private DateTime?  fechaDivorcio;
    private int cantidadHijos;
    private eCivil estadoCivil;
    private TituloUniversitario? titulo;
    public Empleado(string nombre, string apellido, string direccion, DateTime fechaNacimiento, eCivil estadoCivil, int cantidadHijos, DateTime fechaIngreso, double sueldoBase, DateTime? fechaDivorcio = null, TituloUniversitario? titulo = null){
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBase = sueldoBase;
        this.estadoCivil = estadoCivil;
        this.fechaDivorcio = fechaDivorcio;
        this.cantidadHijos = cantidadHijos;
        this.titulo = titulo;
    }

    private int obtenerAntiguedad(){
        int antiguedad = DateTime.Now.Year - this.fechaIngreso.Year;

        if((DateTime.Now.Month == this.fechaIngreso.Month && DateTime.Now.Day < this.fechaIngreso.Day) || DateTime.Now.Month < this.fechaIngreso.Month) antiguedad--;

        return antiguedad;
    }

    private int obtenerEdad(){

        int edad = DateTime.Now.Year - this.fechaNacimiento.Year;

        if((DateTime.Now.Month == this.fechaNacimiento.Month && DateTime.Now.Day < this.fechaNacimiento.Day) || DateTime.Now.Month < this.fechaNacimiento.Month) edad--;

        return edad;

    }
    
    private double obtenerBonusAntiguedad(){
        int antiguedad = obtenerAntiguedad();
        double bonus = 0;
        if(antiguedad >= 20) {
            bonus = 0.25*this.sueldoBase;
        } else {
            bonus = (antiguedad/100)*this.sueldoBase;
        }
        return bonus;
    }

    private double obtenerSalario(){
        return sueldoBase + this.obtenerBonusAntiguedad() - (sueldoBase*0.15);
    }

    public void mostrarInfoEmpleado(){
        Console.WriteLine($"-> EMPLEADO: {this.apellido}, {this.nombre}");
        Console.WriteLine($" - Edad: {this.obtenerEdad()} años");
        Console.WriteLine($" - Salario: ${this.obtenerSalario()}");
        Console.WriteLine($" - Antigüedad: {this.obtenerAntiguedad()} años");
       
    }
}