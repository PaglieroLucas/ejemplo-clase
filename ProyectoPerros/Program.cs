using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPerros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Perro perro_1 = new Perro("Border Collie", "Macho","Blanco y negro");
            Perro perro_2 = new Perro("Pastor Aleman", "Macho", "Negro");
            Perro perro_3 = new Perro("Dogo", "Hembra", "Blanca");
            Perro perro_4= new Perro("Chihuahua", "Macho", "Marron");


            Console.WriteLine("Ingrese la edad del perro 1");
            perro_1.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese con cuantos perros convive: ");
            perro_1.comp = int.Parse(Console.ReadLine());



            Console.WriteLine("Ingrese la edad del perro 2");
            perro_2.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese con cuantos perros convive: ");
            perro_2.comp = int.Parse(Console.ReadLine());



            Console.WriteLine("Ingrese la edad del perro 3");
            perro_3.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese con cuantos perros convive: ");
            perro_3.comp = int.Parse(Console.ReadLine());



            Console.WriteLine("Ingrese la edad del perro 4");
            perro_4.Edad = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese con cuantos perros convive: ");
            perro_4.comp = int.Parse(Console.ReadLine());

            perro_1.ficha();
            perro_1.vejez();
            perro_1.compa();

            perro_2.ficha();
            perro_2.vejez();
            perro_2.compa();

            perro_3.ficha();
            perro_3.vejez();
            perro_3.compa();

            perro_4.ficha();
            perro_4.vejez();
            perro_4.compa();
        }
    }
}
