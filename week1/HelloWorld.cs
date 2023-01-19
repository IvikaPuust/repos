//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name: ");
//string - sõna

string userName= Console.ReadLine(); //input

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation
Console.WriteLine($"Hello, {userName}!");