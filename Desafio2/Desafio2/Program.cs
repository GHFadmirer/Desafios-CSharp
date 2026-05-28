double altura, peso, imc;
string imcComentario;

Console.WriteLine("Digite o valor de sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do seu peso: ");
peso = Convert.ToDouble(Console.ReadLine());

if (altura >= 100)
    altura /= 100;

imc = Math.Round(peso / (altura * altura), 3);

//ignorando graus de obesidade

if (imc <= 18.5)
    imcComentario = "abaixo do peso";
else if (imc <= 25)
    imcComentario = "normal";
else 
    imcComentario = "obeso";

Console.WriteLine("Seu valor de imc é de " + imc + " e você se classifica como " + imcComentario);