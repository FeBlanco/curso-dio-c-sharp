using ExemploFundamentos.Models;

Calculadora calc = new Calculadora();
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(25);

int numeroIncremento = 10;
int numeroDecremento = 20;

Console.WriteLine($"Incrementar o {numeroIncremento}");
numeroIncremento++;
Console.WriteLine(numeroIncremento);

Console.WriteLine($"Decrementar o {numeroDecremento}");
numeroDecremento--;
Console.WriteLine(numeroDecremento);
