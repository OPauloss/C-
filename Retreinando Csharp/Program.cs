
// Variables
/*

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


// Constants = immutable values which are known at compile time and do not change for the life of the program

const double pi = 3.14159; // can't change this value after declaration

Console.WriteLine(pi);
Console.ReadKey();


// Type casting

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


// User input

Console.Write(" What's yout name? --> ");
string name = Console.ReadLine(); // read the user input
Console.WriteLine("Olá " + name);
Console.ReadKey();


// Arithmetic operators

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

// Biblioteca Math

double a = Math.Pow(4,2); // Potency
double b = Math.Sqrt(81); // Square root
double c = Math.Abs(-3); // absolute value
double d = Math.Round(3.6); // Arredonda para o valor mais próximo.
double e = Math.Ceiling(3.14); // Arredonda para cima
double f = Math.Floor(3.6); // Arredonda para baixo
double g = Math.Max(a, b); // Valor máximo entre dois valores
double h = Math.Min(c, e); // Valor mínimo entre dois valores

Console.WriteLine(h);
*/

// Valores aleatórios

Random random = new Random(); // Objeto do tipo Random
int num = random.Next(1, 21); // Gera um número aleatório entre 1 e 20. Rola um d20 xD.
int num2 = num + 100; // É possível incrementar, também
double num3 = random.NextDouble(); // Gera um número decimal entre 0 e 1.

Console.WriteLine(num);
Console.ReadKey();  




