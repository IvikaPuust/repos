int i = 0;
int sum = 0;

for(i = 0; i <= 10; i++)
{
    Console.WriteLine($"Blah {i}");
    Console.WriteLine($"Summa {sum}");
    sum = sum + i;
}
Console.WriteLine($"Lõppväärtus {i}");
Console.WriteLine($"Lõppsumma {sum}");

if ( i <= 0)
{
    Console.WriteLine("Me ei näe seda kirja");
}
else
{
    Console.WriteLine("Loop töötas!");
}
