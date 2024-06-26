using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN03_01
{
    public class Cliente
    {
        public Cliente(int codigo, string nome, decimal rendamensal){
           Codigo = codigo;
           Nome = nome;
           RendaMensal = rendamensal;
           ClientePremium = RendaMensal >= 1200;
        }

        public int Codigo{get; private set;}
        public string Nome{get; set;}
        public decimal RendaMensal{get;set;}
        public bool ClientePremium{get;set;}

        public bool PromoverCliente(decimal valor){
            if (valor >= 5000){
                ClientePremium = true;
                return true;
            }
            return false;            
        }
    }
}