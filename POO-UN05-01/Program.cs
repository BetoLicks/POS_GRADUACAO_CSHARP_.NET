using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN05_01
{
    public class Progrmama
    {
        static void Main(string[] args){
         try
         {
            var valor = 10;
            var retorna = valor / 0;
         }
         catch (Exception erro)
         {
            Console.WriteLine("ERROOOOOO: " + erro.Message);
         }
        }
    }        
}