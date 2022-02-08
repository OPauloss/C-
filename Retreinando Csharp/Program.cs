


/*
static void Constructors()
{

    // Constructor = A special method in a class
    //               Same name as the class name
    //               Can be used to assign arguments to fields when creating an object

    Human human1 = new Human("Rick", 65); // Passando parâmetros para o objeto
    Human human2 = new Human("Morty", 16);

    class Human
    {
        public string name;
        public int age;

        public Human(string name, int age) // Parameters of the object
        {
            this.name = name;
            this.age = age;
        }
    }
}

static void Objects()
{

    //Objetos: Uma instância de uma classe
            // Uma classe pode ser usada como modelo para criar objetos (POO)
            // Objetos podem ter "fields" e "methods" (características e ações) 

    Human human1 = new Human(); // Human object named human1
    Human human2 = new Human(); // Human object named human2
    human1.name = "Rick"; // Name of human1 is Rick
    human1.age = 65; // Rick is 65 years old
    human2.name = "Morty";
    human2.age = 16;

    human1.Eat();
    human1.Sleep();

    class Human // Objeto da classe Human criado
    {
        // Características do objeto
        public string name;
        public int age;


        // O que o objeto Human faz:
        public void Eat()
        {
            Console.WriteLine($"{name} is eaten");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}

static void Variables()
{

    int x; //declaration of an integer
    x = 123; //initialization

    int y = 321; //declaration + initialization
    int z = 123 + 321;
    double height = 1.74; // decimal number with more precision than float numbers
    bool alive = true; // boolean value, only true or false
    char symbol = '@'; // unique character, must be declared within single quotes.
    string name = "Paulo"; // series of chars
    string userName = symbol + name; // variable combinations

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine("Hi, " + name);
    Console.WriteLine("Your height is " + height + "cm");
    Console.WriteLine("Are you alive? " + alive);
    Console.WriteLine("Your symbol is " + symbol);
    Console.WriteLine("Your username is " + userName);
    Console.ReadKey(); // 
}

static void Constants()
{ //immutable values which are known at compile time and do not change for the life of the program

    const double pi = 3.14159; // can't change this value after declaration

    Console.WriteLine(pi);
    Console.ReadKey();
}

static void Type_casting()
{
    const double pi = 3.14;
    int b = Convert.ToInt32(pi); // Converting double to int
    Console.WriteLine(b.GetType()); // verifying the data type

    int c = 123;
    double d = Convert.ToDouble(c) + 0.1; // Converting int to double
    Console.WriteLine(d);
    Console.WriteLine(d.GetType());
    string g = "$";
    char h = Convert.ToChar(g);
    Console.WriteLine(h.GetType());
    Console.ReadKey();
}

static void User_input()
{

    Console.Write(" What's yout name? --> ");
    string name = Console.ReadLine(); // read the user input
    Console.WriteLine("Olá " + name);
    Console.ReadKey();
}

static void Arithmetic_operators()
{

    int friends = 5;
    friends = friends + 2; // increment friends by + 2
    friends += 2; // the same as above
    friends++; // increment friends + 1
    Console.WriteLine(friends);
    Console.ReadKey();

    friends = friends - 1; //decrement friends by 1
    friends -= 1; // same as above
    friends--;  // decrement friends by 1

    // + = increment
    // - = decrement
    // * = multiplication
    // / = division
    // % = remainder of the division
}

static void Biblioteca_Math() 
{ 

    double a = Math.Pow(4,2); // Potency
    double b = Math.Sqrt(81); // Square root
    double c = Math.Abs(-3); // absolute value
    double d = Math.Round(3.6); // Arredonda para o valor mais próximo.
    double e = Math.Ceiling(3.14); // Arredonda para cima
    double f = Math.Floor(3.6); // Arredonda para baixo
    double g = Math.Max(a, b); // Valor máximo entre dois valores
    double h = Math.Min(c, e); // Valor mínimo entre dois valores

    Console.WriteLine(h);
}

static void Valores_aleatórios()
{

    Random random = new Random(); // Objeto do tipo Random
    int num = random.Next(1, 21); // Gera um número aleatório entre 1 e 20. Rola um d20 xD.
    int num2 = num + 100; // É possível incrementar, também
    double num3 = random.NextDouble(); // Gera um número decimal entre 0 e 1.

    Console.WriteLine(num);
    Console.ReadKey();
}

static void String_methods()
{

    string fullName = "Paulo Henrique";
    string phone = "123-456-789-0";

    Console.WriteLine(fullName.ToUpper()); // PAULO HENRIQUE
    Console.WriteLine(fullName.ToLower()); // paulo henrique
    string userName = fullName.Insert(0, "@");
    Console.WriteLine(userName);
    string tratamento = fullName.Insert(0, "Senhor ");
    Console.WriteLine(tratamento);
    Console.WriteLine(fullName.Length); // It is NOT a method. It is a property of a variable.
    string firstName = fullName.Substring(0, 5);
    Console.WriteLine(firstName);
    Console.WriteLine(phone.Replace("-", ".")); // 123.456.789.0

}

static void if_statements()
{
    Console.Write("Digite a sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18 && idade < 110)
    {
        Console.WriteLine("Pode entrar!");
    }
    else if (idade < 18 && idade > 0)
    {
        Console.WriteLine("Desculpe, você precisa ter 18 anos ou mais para poder entrar.");
    }
    else if (idade >= 110)
    {
        Console.WriteLine("Desculpa aí, você é muito velho(a) para entrar.");
    }
    else
    {
        Console.WriteLine("Você ainda não nasceu!");
    }
}

static void switche_cases()

    // switch is an efficient alternative to many else if statements.
{
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
        default:
            Console.WriteLine("Erro. Verifique os dados e tente novamente.");
            break;
    }

    Console.Write("Finalmente, digite o ano de nascimento [AAAA]: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Você nasceu em {0} de {1} de {2}", dia, mes, ano);

    Console.ReadKey();
}

static void Logical_operators()
{
    // Logical operators = can be used to check if more than 1 condition is true/false
    // && (and)
    // || (or)

    Console.WriteLine("What's the temperature outside? (C): ");
    double temp = Convert.ToDouble(Console.ReadLine());

    if (temp >= 10 && temp <= 25) // if temp is greater or equal than 10 AND temp is lesser or equal to 25, do:
    {
        Console.WriteLine("It's warm outside!");
    }
    else if (temp <= -50 || temp >= 50) // if temp is lesser than or equal to -50 OR temp is greater than or equal to 50, do:
    {
        Console.WriteLine("DO NOT GO OUTSIDE!");
    }
}

static void while_loops()
{
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    while (name == "")
    {
        Console.WriteLine("You didn't enter your name! ");
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
    }
    Console.WriteLine("Hello, {0}!", name);
}

static void For_loops()
{
    // for loop = repeats some code a FINITE amount of times.
    for (int c = 0; c <= 10; c++)
    {
        Console.WriteLine(c);
    }
}

static void nested_loops()
{
    Console.Write("Enter the number of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of columns: ");
    int col = Convert.ToInt32(Console.ReadLine());
    Console.Write("What symbol you want to repeat? ");
    char symbol = Convert.ToChar(Console.ReadLine());

    for (int c = 0; c < col; c++)
    {
        for (int r = 0; r < row; r++)
        {
            Console.Write(symbol);
        }
        Console.Write("\n");
    }
    Console.ReadKey();
}

static void Number_guessing_game()
{

    int guess;
    int number;
    bool playAgain = true;
    int guesses = 0;

    while (playAgain)
    {
        Console.WriteLine("Tente adivinhar qual número estou pensando! (Digite um número entre 0 e 100): ");
        Random random = new Random();
        number = random.Next(0, 101);
        guess = Convert.ToInt32(Console.ReadLine());


        while (guess != number)
        {

            if (guess < number)
            {
                Console.WriteLine("Chute mais alto...");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            else if (guess > number)
            {
                Console.WriteLine("Chute mais baixo...");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            guesses++;

        }
        Console.WriteLine("Acertou na {0}ª tentativa!!", guesses);
        Console.WriteLine("Quer jogar de novo? [s/n]");
        string res = (Console.ReadLine());
        res = res.ToUpper();
        if (res == "N")
        {
            playAgain = false;
        }
        else if (res == "S")
        {
            playAgain = true;
            guesses = 0;
        }
    }
}

static void Jokenpô()
{

    bool playAgain = true;
    int player;
    int cpu;


    while (playAgain)
    {
        Console.WriteLine("Vamos jogar Jokenpô!");
        Console.WriteLine("Digite [ 1 ] para PEDRA");
        Console.WriteLine("Digite [ 2 ] para PAPEL");
        Console.WriteLine("Digite [ 3 ] para TESOURA");
        Console.Write(" ---> ");
        player = Convert.ToInt32(Console.ReadLine());
        while (player != 1 && player != 2 && player != 3)
        {
            Console.WriteLine("Opção Inválida.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vamos jogar Jokenpô!");
            Console.WriteLine("Digite [ 1 ] para PEDRA");
            Console.WriteLine("Digite [ 2 ] para PAPEL");
            Console.WriteLine("Digite [ 3 ] para TESOURA");
            Console.Write(" ---> ");
            player = Convert.ToInt32(Console.ReadLine());
        }
        Random random = new Random();
        cpu = random.Next(1, 4);

        switch (cpu)
        {
            case 1:
                Console.WriteLine("CPU: [PEDRA]");
                break;
            case 2:
                Console.WriteLine("CPU: [PAPEL]");
                break;
            case 3:
                Console.WriteLine("CPU: [TESOURA]");
                break;
        }

        switch (player)
        {
            case 1:
                Console.WriteLine("Player: [PEDRA]");
                if (cpu == 1)
                {
                    Console.WriteLine("EMPATE!");
                }
                else if (cpu == 2)
                {
                    Console.WriteLine("CPU ganhou...");
                }
                else
                {
                    Console.WriteLine("Player GANHOU!!");
                }
                break;
            case 2:
                Console.WriteLine("Player: [PAPEL]");
                if (cpu == 2)
                {
                    Console.WriteLine("EMPATE!");
                }
                else if (cpu == 1)
                {
                    Console.WriteLine("Player GANHOU!!");
                }
                else
                {
                    Console.WriteLine("CPU ganhou...");
                }
                break;
            case 3:
                Console.WriteLine("Player: [TESOURA]");
                if (cpu == 3)
                {
                    Console.WriteLine("EMPATE!");
                }
                else if (cpu == 2)
                {
                    Console.WriteLine("Player GANHOU!!");
                }
                else
                {
                    Console.WriteLine("CPU ganhou...");
                }
                break;

        }
        Console.Write("Quer jogar de novo? [s/n]: ");
        string res = Console.ReadLine();
        res = res.ToLower();
        Console.Clear();
        if (res == "n")
        {
            playAgain = false;
        }

    }

}

static void Calculadora()
{


    
    do{ Console.WriteLine("=============================================================");
        Console.WriteLine("\t\t\tCALCULADORA");
        Console.WriteLine("=============================================================");
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual operação deseja fazer?");
        Console.WriteLine("[ 1 ] Para SOMA");
        Console.WriteLine("[ 2 ] Para SUBTRAÇÃO");
        Console.WriteLine("[ 3 ] Para MULTIPLICAÇÃO");
        Console.WriteLine("[ 4 ] Para DIVISÃO");
        int option = Convert.ToInt32(Console.ReadLine());

        double soma = num1 + num2;
        double sub = num1 - num2;
        double mult = num1 * num2;
        double div = num1 / num2;

        switch (option)
        {
            
            case 1:
                Console.WriteLine($"O resultado da soma: {num1} + {num2} = {soma}");
                break;
            case 2:
                Console.WriteLine($"O resultado da subtração: {num1} - {num2} = {sub}");
                break;
            case 3:
                Console.WriteLine($"O resultado da multiplicação: {num1} x {num2} = {mult}");
                break;
            case 4:
                Console.WriteLine($"O resultado da divisão: {num1} ÷ {num2} = {div}");
                break;
            default:
                Console.WriteLine($"Valor(es) inválido(s).");
                break;

        }
        Console.Write("Quer continuar? [S/N]: ");
    } while (Console.ReadLine().ToUpper() == "S");

    Console.WriteLine("Tchau!");
    Console.ReadKey();
}

static void Arrays()
{
    string[] cars = { "BMW", "Corsinha", "Celta"}; // criação de um array com itens definidos.
    string [] cars2 = new string[5]; // criação de um array com 5 itens.

    // Todo array tem um limite que deve ser definido com antecedência, ou definido diretamente dentro de chaves.

    cars[0] = "Tesla"; // Mudando um item de dentro do array.

    Console.WriteLine(cars[0]); // Primeiro item do array
    Console.WriteLine(cars[1]); // Segundo item do array
    Console.WriteLine(cars[2]); // Terceiro item do array...


    Console.ReadKey();

    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"Carro {i + 1} = {cars[i]}");
    }
}

static void Foreach()
{
    string[] cars = {"BMW", "Tesla", "Fusquinha"};

    foreach (string car in cars) // foreach é uma outra forma de loop do tipo "for", mais fácil de escrever, mas menos flexível, porque não é possível definir o passo, como no "for" convencional.
    {
        Console.WriteLine(car);
    }
}

static void Functions()
{
    //Para declarar uma função, é só começar com static void <nomedaFunção()>
    //Depois, basta chamar a função dentro do escopo principal.
}

static void Method_overloading()
{
    Console.WriteLine(Multiply(5,4));

    static double Multiply(double a, double b) // Tem que trocar o "void" pelo datatype do retorno. Caso não haja nenhum retorno, deixe "void".
    {
        return a * b;
    }
    //static double Multiply(double a, double b, double c) // É possível ter dois métodos com o mesmo nome, desde que eles tenham "assinaturas" diferentes, isto é, parâmetros diferentes.
   // {
   //     return a * b * c;
   // }
    // Por alguma razão o overloading não está funcionando... 
}

static void Params_keyword() // A keyword "params" faz com que uma função possa receber valores parâmetros ilimitados. Para isso, é preciso criar um array e passá-lo como método de uma função:
{
    double total = 0;
    total = Checkout(3.99, 1.00, 7.90, 10.90, 43.88);
    Console.WriteLine(total);

    static double Checkout(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}

static void exception_handling() // exceptions são erros que podem acontecer durante o programa.
{

    try // tentando executar o programa
    {
        Console.Write("Digite o primeiro número da divisão: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número da divisão: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int res = num1 / num2;
        Console.WriteLine($"O resultado é {res}");
    }
    catch (DivideByZeroException) // em caso de tentativa de divisão por zero, faça:
    {
        Console.WriteLine("Não dá pra dividir por zero...");
    }
    catch(FormatException) // caso o usuário digite um formato errado, faça:
    {
        Console.WriteLine($"Números só podem ser divididos por números...");
    }
    catch(Exception) // caso aconteça qualquer outro tipo de erro, faça:
    {
        Console.WriteLine($"Alguma coisa deu errado... Verifique os dados.");
    }
    finally // No final, independente se ocorreu erros ou não durante o programa, faça:
    {
        Console.WriteLine("Obrigado por utilizar o programa.");
    }
}

static void conditional_operator()
{

    // Conditional operator = used in conditional assignement if a condition is true or false
    // (condition) ? x : y

    double temperature = 20;
    string message;

    //if (temperature >= 15)
    //{
    //    message = "It's warm outside!";
    //}
    //else
    //{
    //    message = "It's cold outside!";
    //}
    //Console.WriteLine(message);

    // The same can be written as:

    message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
    Console.WriteLine(message);
    Console.ReadKey();
}

static void Multidimensional_arrays()
{
    // Maneira tradicional de se criar arrays:

    //string[] playstation = {"God of War", "The Last of Us", "Uncharted"};
    //string[] xbox = {"Halo", "Gears of War", "Sunset Overdrive"};
    //string[] nintendo = {"Pokémon", "Mario", "Animal Crossing"};

    // Maneira resumida de se fazer múltiplos arrays.

    string[,] videoGames = 
    {
        {"God of War", "The Last of Us", "Uncharted"},
        {"Halo", "Gears of War", "Sunset Overdrive"},
        {"Pokémon", "Mario", "Animal Crossing"}
    };

    videoGames[0, 2] = "Spiderman"; // trocando Uncharted (primeiro array [0], terceiro item [2]) por Spiderman.
    videoGames[2, 2] = "Zelda"; // trocando Animal Crossing por Zelda.
}

static void classes()
{


    // Uma classe é um conjunto de funções com códigos relacionados. Por exemplo, a biblioteca Math é uma classe, contendo diversas funções de operações matemáticas. É possível criar a própria classe:

    //class Messages
    {
        void Hello()
        {
            Console.WriteLine("Hello!");
        }

        void Waiting()
        {
            Console.WriteLine("Waiting for something to happen?");
        }

        void Bye()
        {
            Console.WriteLine("See you later!");
        }
    }

    // Claro que, as classes são feitas para guardar métodos mais completos, mas isso serve de exemplo. Classes são um conjunto de métodos relacionados. Assim como os módulos no Python.
    // Também é possível criar as classes em outro repositório, fora do programa principal. Para isso, basta seguir:

    // Clique direito no nome do programa dentro do gerenciador de soluções > adicionar > classe. Selecione o item classe na janela que se abrir > dê um nome a classe > clique em adicionar.
    // Depois, será necessário recortar o código do programa principal, se houver, e colar na nova janela de classe.
    // Para acessar os métodos de uma classe que está em outro repositório:
    // > Defina a predefinição das funções da classe para "public static".
    // > No programa principal, digite: <nomedaClasse>.<nomedaFunção(); . Por exemplo: Messages.Hello();
}
*/