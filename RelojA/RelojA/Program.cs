﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
           
            string numeros = (Console.ReadLine());
            string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
            
                for (int i = 0; i <= numeros.Length - 1; i++)
                {
                    char c = numeros[i];
                    if (c == '0') 
                    {
                        a1 += "#### ";
                        a2 += "#  # ";
                        a3 += "#  # ";
                        a4 += "#  # ";
                        a5 += "#### ";
                    }

                }
                Console.WriteLine(a1);
                Console.WriteLine(a2);
                Console.WriteLine(a3);
                Console.WriteLine(a4);
                Console.WriteLine(a5);
                Console.ReadLine();            
            
        }

    }
}