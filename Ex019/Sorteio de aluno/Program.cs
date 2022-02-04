// Um professor quer sortear um dos seus quatro alunos para apagar o quadro. Faça um programa que o ajude, lendo o nome deles e escrevendo o nome do escolhido.
/*
Console.Write("Digite o nome do 1º aluno: ");
string a1 = Console.ReadLine();
Console.Write("Digite o nome do 2º aluno: ");
string a2 = Console.ReadLine();
Console.Write("Digite o nome do 3º aluno: ");
string a3 = Console.ReadLine();
Console.Write("Digite o nome do 4º aluno: ");
string a4 = Console.ReadLine();

Random r = new Random();
int sorteado = r.Next(1, 5);
switch (sorteado)
{
    case 1:
        Console.WriteLine("O aluno sorteado foi: {0}", a1);
        break;
    case 2:
        Console.WriteLine("O aluno sorteado foi {0}", a2);
        break;
    case 3:
        Console.WriteLine("O aluno sorteado foi {0}", a3);
        break;
    case 4:
        Console.WriteLine("O aluno sorteado foi {0}", a4);
        break;
}
Console.ReadKey();
*/

string[] alunos = new string [4];
for (int a = 0; a <= 3; a++)
{
    Console.Write("Digite o nome do {0}º aluno: ", a + 1);
    alunos[a] = Console.ReadLine();

}

Random r = new Random();
int sorteado = r.Next(1, 5);


switch (sorteado)
{
    case 1:
        Console.WriteLine("O aluno sorteado foi {0}", alunos[0]);
        break;
    case 2:
        Console.WriteLine("O aluno sorteado foi {0}", alunos[1]);
        break;
    case 3:
        Console.WriteLine("O aluno sorteado foi {0}", alunos[2]);
        break;
    case 4:
        Console.WriteLine("O aluno sorteado foi {0}", alunos[3]);
        break;
}
Console.ReadKey();

