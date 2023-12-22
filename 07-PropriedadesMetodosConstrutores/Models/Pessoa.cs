using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa  // - PascalCase
    {
        public Pessoa(){} //construtor - mesmo nome da classe + parametros
        public Pessoa(string nome,  string sobrenome)
        {
            Nome = nome; // Propriedade = parametro
            Sobrenome = sobrenome;
        } 

        // propriedade - PascalCase
        // propriedade - get = pegar(obter) o valor, set = atribuir um valor
        // public qualquer um pode acessar
        // private somente a classe pode acessar

        private string? _nome;
        private int _idade;
        public string? Nome 
        { 
            get => _nome.ToUpper(); //body expression

            // {
            //     return _nome.ToUpper();
            // }

            set //validando a propriedade
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }

        //propriedades somente leitura (sobrenome, NomeCompleto)
        public string? Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // combinar outras propriedades em uma única propriedade

        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        } 

        public void Apresentar() //Metodo = uma ação - PascalCase
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e tenho {Idade} anos"); // ação do metodo - pode se usar \n para  quebra de linha
        }
    }

}