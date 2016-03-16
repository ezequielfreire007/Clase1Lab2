﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoDeTryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uso de Try Parse";
            String dato;
            Console.WriteLine("Ingrese su edad: ");
            dato = Console.ReadLine();
            int numero;
            //numero = int.Parse(dato);
            while(int.TryParse(dato,out numero)==false)
            {
                Console.WriteLine("Error intente reingresando un numero.");
                dato = Console.ReadLine();
            }
        }
    }
}
