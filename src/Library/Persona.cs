using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Persona
    {
        private string nombre;

        private int edad;

        private List<Persona> children = new List<Persona>();

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public ReadOnlyCollection<Persona> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Persona (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void AddChildren(Persona p)
        {
            this.children.Add(p);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}