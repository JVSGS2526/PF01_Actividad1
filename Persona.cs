using System;

public class Persona
{
    public Persona()
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;

    }

    public string MostrarDatos()
    {
        return $"Nombre: {this.Nombre}, Edad: {this.Edad}";
    }
}
}
