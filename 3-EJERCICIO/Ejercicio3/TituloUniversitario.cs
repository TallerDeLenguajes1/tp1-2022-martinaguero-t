namespace Ejercicio3;

class TituloUniversitario {
    string titulo;
    string universidad;

    public TituloUniversitario(string titulo, string universidad){
        if(string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(universidad)){
            throw new ArgumentNullException("Falta alguno de los campos pedidos");
        } else {
            this.titulo = titulo;
            this.universidad = universidad;
        }
    }
}
