using System;
using System.Collections.Generic;

namespace Library
{
    public interface Visitor
    {
        void Operaciones(Operaciones operaciones){}
        void VisitPersona(Persona persona){}
        void VisitNode(Node node){}
    }
}