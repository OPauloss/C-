// Faça um programa que leia algo pelo teclado e mostre na tela o seu tipo primitivo e todas as informações possíveis sobre ele.

Console.Write("Digite algo: ");
var algo = Console.ReadLine();
var type = algo.GetType();
Console.WriteLine(type);

// Como o c# é uma linguagem de tipagem estática, acredito que não é possível mudar seu tipo no momento da captura dos dados do usuário. Portanto, a variável var sempre vai retornar uma string.

Console.ReadKey();
