using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Persona p1 = new Persona("Gerardo",32);
            Persona p2 = new Persona("Faker",12);
            Persona p3 = new Persona("Leona",3);
            Persona p4 = new Persona("Hasbulla",20);
            Persona p5 = new Persona("Mr.Beast",38);
            Persona p6 = new Persona("Santiago",18);
            Persona p7 = new Persona("Mirtiña",1000000);
            Persona p8 = new Persona("Jisus",1000000000);

            p7.AddChildren(p2);
            p7.AddChildren(p3);

            p1.AddChildren(p4);
            p1.AddChildren(p5);

            p6.AddChildren(p8);
        }
    }
}
