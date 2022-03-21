// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

/*int number1a = 45;
int number2 = 7;
*/
double result = 0;
Console.WriteLine($"Please enter the number!");
string number1a = Console.ReadLine();
int number1 = int.Parse(number1a);
Console.WriteLine($"Please enter another the number!");
string number2a = Console.ReadLine();
int number2 = int.Parse(number2a);

Console.WriteLine($"Please enter the type of calculation you want to do!");

string calcType1 = Console.ReadLine();
char calcType = char.Parse(calcType1);

switch (calcType)
{
    case '+':
        result = number1 + number2;
        Console.WriteLine($"{result}");
        break;
    case '-':
        result = number1 - number2;
        Console.WriteLine($"{result}");
        break;
    case '/':
        result = number1 / number2;
        Console.WriteLine($"{result}");
        break;
    case '*':
        result = number1 * number2;
        Console.WriteLine($"{result}");
        break;
    case '%':
        result = number1 % number2;
        Console.WriteLine($"{result}");
        break;
    case 'p':
        Console.WriteLine($"Numbers are {number1} and {number2}");
        break;
    case 'b':
        result = (Math.Max(number1, number2));
        Console.WriteLine($"{result}");
        break;
    case 's':
        result = (Math.Min(number1, number2));
        Console.WriteLine($"{result}");
        break;
}