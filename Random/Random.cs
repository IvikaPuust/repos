//Console.WriteLine("Sisesta number 1");
//int input1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Sisesta number 2");
//int input2 = Int32.Parse(Console.ReadLine());



//Random introduction

Random rnd = new Random();

//int myRandomNumb = rnd.Next(0, 30);


int myRandomNumb;
int myRandomSum = 0;

for (int i = 0; i < 10; i++)
{
    myRandomNumb = rnd.Next(0, 20);
    Console.WriteLine($"Minu suvaline number: {myRandomNumb}");
    myRandomSum = myRandomSum + myRandomNumb;
}

Console.WriteLine($"Minu suvaline summa on: {myRandomSum}");

