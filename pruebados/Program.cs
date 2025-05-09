using System;

namespace capturanombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Su nombre es: " + nom);
            Console.WriteLine("Agrege su Apellido");
            string ape = Console.ReadLine();
            Console.WriteLine("Su nombre completo es: " + nom + ape);
        }
    }
}

public class Class1
{
    public Class1()
    {
    }
}
