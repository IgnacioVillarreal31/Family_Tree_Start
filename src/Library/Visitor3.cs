using System;
using System.Collections.Generic;

namespace Library
{
    public class Visitor3
    {
        public void Operaciones(Operaciones2 operaciones)
        {
            operaciones.Accept(this);
        }
        public void VisitPersona(Persona persona)
        {
            string val = persona.MasLargo();
            Console.WriteLine("La persona con el nombre mas largo es : " + val);
        }
    }
}