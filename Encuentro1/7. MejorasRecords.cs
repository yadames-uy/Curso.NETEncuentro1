namespace Encuentro1;

public class EjemploRecords
{
    // Declaración simplificada
    public record Persona(string Nombre, int Edad);

    // Declaración c# 9
    public record Persona2
    {
        public string Nombre { get; init; }
        public int Edad { get; init; }

        public Persona2(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }

    // Propiedades calculables y sobrecarga del metodo ToString()
    public record Persona3(string nombre, int edad)
    {
        public bool EsMenorDeEdad()
        {
            return edad <= 18;
        }

        public override string ToString()
        {
            return $"{nombre} {edad}";
        }
    }

    public void Ejemplo()
    {
        Persona3 persona3 = new("Juan", 17);

        var esMenor = persona3.EsMenorDeEdad;

        Console.WriteLine(persona3.ToString());
    }
}