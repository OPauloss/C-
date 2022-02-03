// Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado.

Console.Write("Km rodados: ");
double rodados = Convert.ToDouble(Console.ReadLine()) * 0.15;
Console.Write("Dias alugados: ");
int dias = Convert.ToInt32(Console.ReadLine()) * 60;
double preco = rodados + dias;
string Preco = preco.ToString("C");

Console.WriteLine("Total a pagar: {0}", Preco);

