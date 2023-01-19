// For-Loop

int i = 0;

for (i = 0; i < 12; i++)
{
    Console.WriteLine("Hihihi Hahahaha");
}

Console.WriteLine(i);

Console.WriteLine("Programmi lõpp");

for (int j = 3; j > 0; j--)
{
    Console.WriteLine("Hello, World!");
}

for (int k = 1; k < 5; k++)
{
    Console.WriteLine("Don't worry, be happy :)");
}

Console.WriteLine("Enter a number");
int userNumber = Int32.Parse(Console.ReadLine());

for(int u = 0; u < 10; u++)
{
    Console.WriteLine($"{u + 1} * {userNumber} = {( u + -1) * userNumber}");
}