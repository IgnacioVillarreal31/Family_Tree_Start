using System;
using System.Collections.Generic;

namespace Library
{
    public class Visitor1 : Visitor
    {
        public void Operaciones(Operaciones operaciones)
        {
            operaciones.Accept(this);
        }
        public void VisitPersona(Persona persona)
        {
            int val = persona.AñosTotales();
            Console.WriteLine("La suma total de edades es de : " + val + " años");
        }

        public void VisitNode(Node node)
        {
            int val = node.AñosTotales();
            Console.WriteLine("La suma total de edades es de : " + val +" años");
        }
    }
}