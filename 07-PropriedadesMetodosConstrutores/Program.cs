using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Blanco");
// p1.Nome = "Felipe";
// p1.Sobrenome ="Blanco";
// p1.Idade = 30;
// p1.Apresentar();
Pessoa p2 = new Pessoa(nome: "Fernanda", sobrenome: "Blanco"); //instanciando com os construtores
// p2.Nome = "Fernanda";
// p2.Sobrenome ="Blanco";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();