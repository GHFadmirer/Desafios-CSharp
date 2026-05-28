string sinal;
double valor1, valor2, total = 0;

Console.WriteLine("Insira um valor para a primeira casa: ");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira um valor para a segunda casa: ");
valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o tipo de operação (+, -, /, *): ");
sinal = Console.ReadLine();

switch (sinal)
{
    case "+":
        total = valor1 + valor2;
        break;
    case "-":
        total = valor1 - valor2;
        break;
    case "/":
        total = valor1 / valor2;
        break;
    case "*":
        total = valor1 * valor2;
        break;
}
Console.WriteLine(valor1 + " " + sinal + " " + valor2 + " = " + Math.Round(total,2));