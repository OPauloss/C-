// Faça um programa que leia um número inteiro e mostre na tela o seu sucessor e seu antecessor.

Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());
int sup = num + 1;
int sub = num - 1;

Console.WriteLine("Para o número {0}, seu antecessor é {1} e seu sucessor é {2}.", num, sub, sup);

Console.ReadKey();
