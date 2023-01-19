// AND , OR Exercises
//Math >= 90; Biology >=90, Chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math result: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result: ");
chemistry = Int32.Parse(Console.ReadLine());

//AND ( && ) EXERCISE

//if (math >= 90 && biology >= 90 && chemistry >= 90)
//{
//    Console.WriteLine("Congratulations! You're accepted!");
//}
//else
//{
//    Console.WriteLine("Your application can't be approved!");
//}


//OR ( || ) EXERCISE

if (math >= 90 || biology >= 90 || chemistry >= 90)
{
    Console.WriteLine("Congratulations! You're accepted!");
}
else
{
    Console.WriteLine("Your application can't be approved!");
}
