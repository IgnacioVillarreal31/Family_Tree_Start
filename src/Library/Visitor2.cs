using System;
using System.Collections.Generic;

namespace Library
{
    public class Visitor2 : Visitor
    {
        public void Operaciones(Operaciones operaciones)
        {
            operaciones.Accept(this);
        }
        public void VisitPersona(Persona persona)
        {
            string val = persona.MasGrande();
            Console.WriteLine("La persona mas vieja es : " + val);
        }

        public void VisitNode(Node node)
        {
            int val = node.MasGrande();
            Console.WriteLine("La persona mas vieja tiene : " + val + " años");
        }
    }
}