// Faça um algoritmo que leia o salário de um funcionário e mostre seu novo salário, com 15% de aumento.

Console.Write("Salário atual: R$");
double salario = Convert.ToDouble(Console.ReadLine());
double aumento = salario + (salario * 15 / 100);
string Aumento = aumento.ToString("C");

Console.WriteLine("Seu novo salário com 15% de aumento é {0}", Aumento);
