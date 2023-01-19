Random rnd = new Random();

int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"Genereeritud number on {cpuRandom}");
    Console.WriteLine("Arva number 1 - 3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Yayyy nii tubli!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Proovi uuesti");
    }
}

Console.WriteLine("Tsaubakaa!");