Console.WriteLine("Sisesta number:");
int userSum = Convert.ToInt32(Console.ReadLine());

// paaris või paaritu

int result = userSum % 2;
Console.WriteLine(result);

if (result != 0)
{
    Console.WriteLine("Number on paaritu");
} else
{
    Console.WriteLine("Number on paaris");
}
