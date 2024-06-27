using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN03_01
{
    public static class ValidadorDeCPF
    {
        public static bool Validar(string numero)
        {
            return numero.Length == 11;
        }
        
    }
}