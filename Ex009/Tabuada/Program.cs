// Faça um programa que leia um número inteiro qualquer e mostre na tela a sua tabuada.

Console.Write("Digite um número inteiro para saber sua tabuada: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("============ Tabuada do {0} ============\n", num);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("\t{0} x {1} = {2}", num, i, num * i);
}
Console.WriteLine("\n");
Console.WriteLine("========================================");
