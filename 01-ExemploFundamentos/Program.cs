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

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// int a = 10;
// int b = 20;

// int c = a + b;
// c = c + 5; // 30 +  5

// c += 5;

// Cast - Casting
// int a = Convert.ToInt32("5"); // quando se usa o Convert pois ele trata os null como 0 e não da erro
// int a = int.Parse("5"); // quando se usa o Parse ele não aceita valores null - e da erro

// int inteiro = 5;
// string a = inteiro.ToString();

// int  a = 5;
// double  b = a;

// int a = int.MaxValue; - Cast implicito
// long b = a;

// double a = 4 / (2 + 2);

// string a = "15-";

// int b = 0;

// int.TryParse(a, out b); // Conversão de maneira segura

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0) {
//     Console.WriteLine("Venda inválida.");
// } 
// else if (possivelVenda) {
//     Console.WriteLine("Venda realizada.");
// } 
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
// Console.WriteLine("Entrada liberada!");
// }
// else{
//     Console.WriteLine("Entrada não liberada");
// }

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
// Console.WriteLine("Aprovado!");
// }
// else{
//     Console.WriteLine("Reprovado");
// }

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
// Console.WriteLine("Vou pedalar");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(25);

// int numeroIncremento = 10;
// int numeroDecremento = 20;

// Console.WriteLine($"Incrementar o {numeroIncremento}");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// Console.WriteLine($"Decrementar o {numeroDecremento}");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// Laço de repetições For
// int numero =  5;

// for(int contador = 0; contador <=10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Laço de repetições While
// int numero = 5;
// int contador = 0;

// while(contador <=10)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6) {
//         break;
//     }
// }

// Laço de repetições Do While
// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (Digite 0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// int[] arrayInteiros =  new int [3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //muda o tamanho do array

// Console.WriteLine("Percorrendo  o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++) {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo  o Array com o FOREACH");
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }

//Lista

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PE");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo  a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo  a Lista com o FOREACH");
// int contadorForeach  = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//     contadorForeach++;
// }

