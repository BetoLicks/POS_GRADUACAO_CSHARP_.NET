using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN04_03
{
    public class ContaCorrente: Conta
    {
        public decimal Limite{get; private set;}
        override public bool Saque(decimal valor){
            if (valor <= (Saldo + Limite)){
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}