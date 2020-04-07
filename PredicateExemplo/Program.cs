using System;
using PredicateExemplo.Entidades;
using System.Collections.Generic;


namespace PredicateExemplo {
    class Program {
        static void Main(string[] args) {

            //EM RESUMO, O PREDICATE É UM DELEGATE(UMA REFERENCIA PARA UMA FUNÇÃO)
            //MAS ELE TEM QUE RETORNAR UMA FUNÇÃO DO TIPO BOLEANO 

            List<Produtos> lista = new List<Produtos>();

            lista.Add(new Produtos("TV", 900.00));
            lista.Add(new Produtos("Mouse", 50.00));
            lista.Add(new Produtos("Tablet", 350.50));
            lista.Add(new Produtos("HD Case", 80.90));

            //exemplo com a função lambda
            lista.RemoveAll(p => p.Preco >= 100.0);
            foreach (Produtos p in lista) {
                Console.WriteLine(p);
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            //exemplo com o predicate correto
            //coloco a função dentro da condição do RemoveAll
            lista.RemoveAll(ProdutoTest);
            foreach (Produtos p2 in lista) {
                Console.WriteLine(p2);
            }
        }
        //função que retorna um resultado boleano se seguir as condições dentro do return!
        public static bool ProdutoTest(Produtos p2) {
            return p2.Preco >= 100.0;
        }
    }
}
