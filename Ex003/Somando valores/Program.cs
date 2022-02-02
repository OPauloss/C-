// 'Crie um script C# que leia dois números e mostre a soma entre eles'

Console.Write("Digite o primeiro valor: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double soma = num1 + num2;

//Console.WriteLine("Somando " +num1+ " e " +num2+ ", obtém-se: " +soma);
Console.WriteLine("Somando {0} e {1}, obtém-se: {2}", num1, num2, soma); // string formatada
Console.ReadKey();
