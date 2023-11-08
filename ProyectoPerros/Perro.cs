using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPerros
{
    internal class Perro
    {

        //CONSTRUCTOR

        public Perro(string raza, string sexo, string color) { 
        
            this.raza = raza;
            this.sexo = sexo;
            this.color = color;
        }
        //Raza
        //Sexo
        //Edad
        //Color
        //Compañia

        private string raza;

        private string sexo;

        private int edad;

        private string color;

        public int comp;

        //PROPIEDADES

        public string Raza { get; set; }

        public string Sexo { get; set; }

        public string Color { get; set; }

        public int Comp { get; set; }

        public int Edad
        { get { return edad; } set {  edad = value; } }


        //METODOS

        //METODO OBTENCION DE DATOS




        //METODO EDAD

        public void vejez()
        {
            if(edad > 10)
            {
                Console.WriteLine("Edad avanzada.");
            }
            else
            {
                Console.WriteLine("Joven.");
            }

        }

        //METODO COMPAÑIA

        public void compa()
        { if(comp < 2) 
            {
                Console.WriteLine("El perro podria necesitar compañia");
            }
        else
            {
                Console.WriteLine("No necesita mas compañia");

            }

            Console.WriteLine("---------------");

            Console.ReadKey();
        }
        //METODO FICHA

        public void ficha()
        {
    

            Console.WriteLine("Raza: "+ raza);
            Console.WriteLine("Sexo "+ sexo);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Edad: " + edad);

         

           
        }

    }
}
