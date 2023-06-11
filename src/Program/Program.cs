using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Persona("Cristian",19));
            Node n2 = new Node(new Persona("Jorge",15));
            Node n3 = new Node(new Persona("Marcos",48));
            Node n4 = new Node(new Persona("Nicolas",17));
            Node n5 = new Node(new Persona("Juan",65));
            Node n6 = new Node(new Persona("Santiago",85));
            Node n7 = new Node(new Persona("Franceso",76));
            Node n8 = new Node(new Persona("Sebastian",12));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n2.AddChildren(n8);

            // visitar el árbol aquí
        }
    }
}
