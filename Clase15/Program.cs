﻿using System;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora myLavadora = new Lavadora();
            Television myTelevision = new Television();
            int opcion;
            Console.WriteLine("ELIJA PRODRUCTO");
            Console.WriteLine("TELEVISOR[1]");
            Console.WriteLine("LAVADORA[2]");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    myTelevision.precioFinal();
                    break;
                case 2:
                    myLavadora.precioFinal();
                    break;
                default:
                    break;
            }
            


        }
    }
}
