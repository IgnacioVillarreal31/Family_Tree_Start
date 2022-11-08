using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node : Operaciones
    {
        private int number;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
        public void Accept(Visitor1 visitor)
        {
            visitor.VisitNode(this);
        }
        public void Accept(Visitor2 visitor)
        {
            visitor.VisitNode(this);
        }

        public int AñosTotales()
        {
            int total = Number;
            foreach (Node nodes in Children)
            {
                total += nodes.Number;
            }
            return total;
        }
        public int MasGrande()
        {
            int mayor = 0;
            foreach (Node nodes in Children)
            {
                if (nodes.Number > mayor)
                {
                    mayor = nodes.Number;
                }
            }
            return mayor;
        }
        
    }
}
