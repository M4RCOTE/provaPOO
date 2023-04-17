using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcoTullioProvaPOO
{
    internal class Onibus : Veiculo
    {
        //atributos
        int assentos;

        //construtores
        public Onibus() : base()
        {
            assentos= 0;
        }

        public Onibus(string placa_, int ano_, int assentos_) : base(placa_, ano_)
        {
            assentos = assentos_;
        }

        //getters e setters
        public int Assentos { get => assentos; set => assentos = value; }

        //outros metodos
        public override double Alugar()
        {
            double diaria = (30 * assentos) - (2023 - this.Ano) * 70;
            return diaria;
        }
    }
}
