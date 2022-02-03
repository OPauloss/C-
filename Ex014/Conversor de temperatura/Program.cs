// Escreva um programa que converta uma temperatura digitada em ºC e converta-a para ºF.

Console.Write("Digite a temperatura atual em Celsius (ºC): ");
double celsius = Convert.ToDouble(Console.ReadLine());
double faren = (celsius * 9 / 5) + 32;

Console.WriteLine("A temperatura atual ({0}ºC) em Farenheit é {1}ºF", celsius, faren);
