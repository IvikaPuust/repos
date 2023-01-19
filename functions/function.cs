Console.WriteLine("Kas sa tuled või lähed? (in/out)");
string vastus = Console.ReadLine();

if (vastus == "in")
{
    PrintHello();
} else
{
    PrintBye();
}







static void PrintHello() //function ehk method
{
    Console.WriteLine("Tere, Maailm");
}

static void PrintBye() //function ehk method
{
    Console.WriteLine("Nägemist!");
}