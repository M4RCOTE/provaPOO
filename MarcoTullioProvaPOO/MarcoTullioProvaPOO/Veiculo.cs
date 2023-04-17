using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcoTullioProvaPOO
{
    internal class Veiculo
    {
        //atributos
        private string placa;
        private int ano;

        

        //construtores
        public Veiculo() { 
            placa = null;
            ano = 0;
        }

        public Veiculo(string placa_, int ano_)
        {
            placa = placa_;
            ano = ano_;

        }

        //getters e setters
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        //outros metodos
        public virtual double Alugar() {
            return 0;
        }
    }
}
