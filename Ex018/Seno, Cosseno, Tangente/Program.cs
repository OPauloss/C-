// Faça um programa que leia um ângulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse ângulo.

Console.Write("Insira o ângulo: ");
double ang = Convert.ToDouble(Console.ReadLine());
ang = ang * Math.PI / 180; // Convertendo para ângulo para radiano
double seno = Math.Sin(ang);
double cos = Math.Cos(ang);
double tan = Math.Tan(ang);
Console.WriteLine("O valor do seno é {0}. Cosseno: {1} e tangente {2}.",seno, cos, tan);
Console.ReadKey();
