namespace Library
{
    public class Persona
    {
        string Nombre {get;set;}
        int Edad {get;set;}
        public Persona (string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}