using ExemploFundamentos.Models;

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

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
Console.WriteLine("Vou pedalar");
}
else{
    Console.WriteLine("Vou pedalar um outro dia");
}

