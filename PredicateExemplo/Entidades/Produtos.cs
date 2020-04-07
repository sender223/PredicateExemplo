using System;
using System.Collections.Generic;
using System.Text;

namespace PredicateExemplo.Entidades {
    class Produtos {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString() {
            return Nome + ", " + Preco.ToString("F2");
        }
    }
}
