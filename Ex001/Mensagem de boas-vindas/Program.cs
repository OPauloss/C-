// 'Crie um script C# que leia o nome de uma pessoa e mostre uma mensagem de boas-vindas de acordo com o valor digitado.'

Console.WriteLine("Hello, what's your name?");
string name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Prazer em conhecê-lo(a), " +name+ "!");
Console.ReadKey();
