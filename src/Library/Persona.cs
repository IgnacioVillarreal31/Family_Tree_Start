using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Persona : Operaciones2
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

        public void Accept(Visitor1 visitor)
        {
            visitor.VisitPersona(this);
        }
        public void Accept(Visitor2 visitor)
        {
            visitor.VisitPersona(this);
        }
        public void Accept(Visitor3 visitor)
        {
            visitor.VisitPersona(this);
        }
        
        public int AñosTotales()
        {
            int total = Edad;
            foreach (Persona personas in Children)
            {
                total += personas.Edad;
            }
            return total;
        }
        public string MasGrande()
        {
            int mayor = 0;
            string nombremayor = "";
            foreach (Persona personas in Children)
            {
                if (personas.Edad > mayor)
                {
                    mayor = personas.Edad;
                    nombremayor = personas.Nombre;
                }
            }
            return nombremayor;
        }
        public string MasLargo()
        {
            int largo = Nombre.Length;
            string nombrelargo = Nombre;
            foreach (Persona personas in Children)
            {
                if (personas.Nombre.Length > largo)
                {
                    largo = personas.Nombre.Length;
                    nombrelargo = personas.Nombre;
                }
            }
            return nombrelargo;
        }
    }
}