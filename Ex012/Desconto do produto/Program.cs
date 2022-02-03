// Faça um programa que leia o preço de um produto e mostre seu novo preço, com 5% de desconto.

Console.Write("Preço original do produto: R$");
double preco = Convert.ToDouble(Console.ReadLine());
double desconto = preco - (preco * 5 / 100);
string Desconto = desconto.ToString("C");

Console.WriteLine("O preço do seu produto com 5% de desconto é {0}.",Desconto);
