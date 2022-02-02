// 'Crie um script Python que leia o dia, o mês e o ano de nascimento de uma pessoa e mostre uma mensagem com a data formatada.'

Console.Write("Por favor, digite o dia de nascimento [DD]: ");
int dia = Convert.ToInt32(Console.ReadLine());
Console.Write("Agora, digite o mês de nascimento [MM]: ");
int mesInt = Convert.ToInt32(Console.ReadLine());
string mes = "0";

switch (mesInt)
{
    case 1:
        mes = "Janeiro";
        break;
    case 2:
        mes = "Fevereiro";
        break;
    case 3:
        mes = "Março";
        break;
    case 4:
        mes = "Abril";
        break;
    case 5:
        mes = "Maio";
        break;
    case 6:
        mes = "Junho";
        break;
    case 7:
        mes = "Julho";
        break;
    case 8:
        mes = "Agosto";
        break;
    case 9:
        mes = "Setembro";
        break;
    case 10:
        mes = "Outubro";
        break;
    case 11:
        mes = "Novembro";
        break;
    case 12:
        mes = "Dezembro";
        break;      
}

Console.Write("Finalmente, digite o ano de nascimento [AAAA]: ");
int ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você nasceu em {0} de {1} de {2}", dia, mes, ano);

Console.ReadKey();
