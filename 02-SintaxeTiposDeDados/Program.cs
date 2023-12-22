using ExemploFundamentos.Models;

// Pessoa pessoa1 = new Pessoa(); //instanciar uma classe - na variavel se usa camelCase

// pessoa1.Nome = "Felipe";
// pessoa1.Idade = 30;
// pessoa1.Apresentar(); 

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;

// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// int quantidade = 1; // quando se coloca o tipo estamos declarando a variavel pela primeira  vez
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// quantidade = 10; // quando passa só a variavel sem o tipo estamos falando para o C# estamos alterando o valor daquela variável já existente
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

