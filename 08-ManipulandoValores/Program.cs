using ExemploExplorando.Models;
using System.Globalization; // alterando a localização do código

// Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Blanco");
// Pessoa p2 = new Pessoa(nome: "Fernanda", sobrenome: "Blanco"); //instanciando com os construtores

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

//Concatenação de valores
// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // alterando a localização do código
// decimal valorMonetario = 1582.40M;
// Console.WriteLine($"{valorMonetario:C}"); // Formatando valores monetários
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // alterando a localização da cultura
// Console.WriteLine(valorMonetario.ToString("C2")); // formatação personalizada

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P")); // Representando porcentagem

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

string dataString = "2023-04-10 23:00";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else 
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

// DateTime data = DateTime.Parse(dataString);
// Console.WriteLine(data);