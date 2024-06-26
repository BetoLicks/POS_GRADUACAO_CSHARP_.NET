using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UN03_01
{
    public class Cliente{
        public const decimal RENDA_MINIMA = 2500;
        public const decimal VALOR_MINIMO = 5000;
        public Cliente(int codigo, string nome, decimal rendamensal){
           Codigo = codigo;
           Nome = nome;
           RendaMensal = rendamensal;
           ClientePremium = RendaMensal >= RENDA_MINIMA;
        }

        public int Codigo{get; private set;}
        public string Nome{get; set;}
        public decimal RendaMensal{get;set;}
        public bool ClientePremium{get;set;}
        public bool ClienteMaster { get; set; }
        public bool PromoverCliente(decimal valor){
            if (valor >= VALOR_MINIMO){
                ClientePremium = true;
                return true;
            }
            return false;            
        }
    }
}