Console.WriteLine("Liitmine või lahutamine: (+/-)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine(" (a) Esimene number:");
int firstNum = Int32.Parse(Console.ReadLine());

Console.WriteLine(" (b) Teine number:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substract(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Vale märgis");
        break;

}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substract(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}