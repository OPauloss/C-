// 'Faça um programa que leia o comprimento do cateto oposto e do cateto adjacente de um triângulo retângulo, calcule e mostre o comprimento da hipotenusa.'

Console.Write("Cateto oposto (lado A): ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Cate adjacente (lado B): ");
double b = Convert.ToDouble(Console.ReadLine());
double hipo = Math.Sqrt((a * a) + (b * b));
hipo = Math.Round(hipo, 2);

Console.WriteLine("Para os lados {0} e {1}, o valor da hipotenusa é {2}", a, b, hipo);
