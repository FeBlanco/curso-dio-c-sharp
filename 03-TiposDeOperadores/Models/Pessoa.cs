using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa  // - PascalCase
    {
        public string? Nome { get; set; } // propriedade - PascalCase
        public int Idade { get; set; } // propriedade // get = pegar o valor, set = atribuir um valor

        public void Apresentar() //Metodo = uma ação - PascalCase
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); // ação do metodo - pode se usar \n para  quebra de linha
        }
    }

}