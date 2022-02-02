// Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.

Console.Write("Digite um valor em metros: ");
double metro = Convert.ToDouble(Console.ReadLine());
double cent = Math.Round(metro * 100, 2);
double mili = Math.Round(metro * 1000, 2);

Console.WriteLine("{0}m em centímetros: {1}cm", metro, cent);
Console.WriteLine("{0}m em milímetros: {1}mm", metro, mili);
