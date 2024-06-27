using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN04_03
{
    public class Conta
    {
        public decimal Saldo {get; protected set;}
        public void Depositar(decimal valor){
            Saldo += valor;
        }

        public virtual bool Saque(decimal valor){
            if (valor <= Saldo){
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}