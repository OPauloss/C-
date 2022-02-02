// Faça um programa que leia a largura e a altura de uma parede em metros, calcule a sua área e a quatidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta uma área de 2m².

Console.Write("Digite a largura da parede em metros: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Agora, digite a altura da parede em metros: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = (x * y) / 2;

Console.WriteLine("A quantidade de tinta necessária para pintar uma parede de {0}m² é de {1}l de tinta.", x * y, z);
