// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// 1.uzdevums
Console.WriteLine("Kā Tevi sauc?");
string username = Console.ReadLine();
string usergreeting = "Sveiks, " + username + "!";
Console.WriteLine(usergreeting);

Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();

// 2.uzdevums
Console.WriteLine("Kāds ir Tavs vecums?");
string age = Console.ReadLine();

int nextage = int.Parse(age);

int result = nextage + 1;

Console.WriteLine("Nākamgad Tev paliks " + result + "." + "Tu esi pilngadīgs.");

Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();

// 3.4.5. uzdevums - Math.Max, Math.Min, %
Console.WriteLine("Ievadiet divus skaitļus atdalot ar ENTER :)!");
string userNumber1 = Console.ReadLine();
string userNumber2 = Console.ReadLine();
int x = int.Parse(userNumber1);
int y = int.Parse(userNumber2);
int largest = Math.Max(x, y );
Console.WriteLine("Lielākais skaitlis ir:" + largest);
int smalest = Math.Min(x, y );
Console.WriteLine("Mazākais skaitlis ir:" + smalest);
int leftAfter = x % y ;
Console.WriteLine("Dalījuma atlikums:" + leftAfter);


Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();
//6.uzdevuma - pāra vai nepāra skaitlis

Console.WriteLine("Ievadiet vienu skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);

Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();

//7.uzdevums - Taisnstūra laukuma aprēķināšana
Console.WriteLine("Ievadiet taisnstūra garumu!");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ievadiet taisnstūra platumu!");
double number2 = double.Parse(Console.ReadLine());
double resultS = number1 * number2;
Console.WriteLine("Taisnstūra laukums ir:" + resultS + "!");

Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();

//8.uzdevums - Taisnleņķa trijstūra laukuma aprēķināšana
Console.WriteLine("Ievadiet taisnlenka trīstūra 1.katetes garumu");
double katete1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ievadiet taisnlenka trīstūra 2.katetes garumu");
double katete2 = double.Parse(Console.ReadLine());
double laukums = katete1 * katete2/2;
Console.WriteLine("Taisnleņka trīstūra laukums ir:" + laukums + "!");

Console.WriteLine();
Console.WriteLine("******************************************");
Console.WriteLine();

//9.uzdevums - Interpolācija
Console.WriteLine("Kāds ir tavs vārds?");
string name = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
int userage = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {name}, tavs vecums ir {userage}!");

