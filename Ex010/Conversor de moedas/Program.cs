// Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e mostre quantos dólares ela pode comprar.

Console.Write("Digite qual é o valor disponível para a compra de dólares: ");
decimal real = Convert.ToDecimal(Console.ReadLine());
decimal dolar = Convert.ToDecimal(5.27);
decimal valor = real / dolar;
//valor = Math.Round(valor, 2);
//dolar = Math.Round(dolar, 2);
string Real = real.ToString("C"); 
string Valor = valor.ToString("C");

// O método ToString("C") retorna o valor dentro da variável como uma string em formato monetário

Console.WriteLine("Com {0} é possível comprar {1}", Real, Valor);
