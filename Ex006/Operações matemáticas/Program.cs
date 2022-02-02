// Crie um algoritmo que leia um número e mostre o seu dobro, triplo e raiz quadrada

Console.Write("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
int dobro = num * 2;
int triplo = num * 3;
double raiz = Math.Sqrt(num);

Console.WriteLine("O dobro do número {0} é {1}. O triplo de {0} é {2}. A raiz quadrada de {0} é {3}", num, dobro, triplo, raiz);
Console.ReadKey();
