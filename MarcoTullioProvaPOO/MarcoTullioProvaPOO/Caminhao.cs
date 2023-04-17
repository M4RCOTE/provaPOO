using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcoTullioProvaPOO
{
    internal class Caminhao : Veiculo
    {
        //atributos
        private int eixos;

        //construtores
        public Caminhao() : base()
        {
            eixos= 0;
        }
        
        public Caminhao(string placa_, int ano_,int eixos_) : base(placa_, ano_)
        {
            eixos = eixos_;
        }


        //getters e setters
        public int Eixos { get => eixos; set => eixos = value; }


        //outros metodos

        public override double Alugar()
        {
            double diaria = (300*eixos) - (2023 - this.Ano)*50;
            return diaria;
        }

    }
}
