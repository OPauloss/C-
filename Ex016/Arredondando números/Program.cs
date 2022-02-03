// Crie um programa que leia um número Real qualquer pelo teclado e mostre na tela a sua porção inteira.\nExemplo: Digite um número: 6.127\nO número 6.238 tem a parte inteira 6.

Console.Write("Digite um número qualquer para receber sua parte inteira: ");
double num = Convert.ToDouble(Console.ReadLine());
int numInt = Convert.ToInt32(Math.Floor(num));

Console.WriteLine("A parte inteira de {0} é {1}.", num, numInt);
