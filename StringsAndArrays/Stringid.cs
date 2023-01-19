//Strings And Arrays

string hello = "tere, Maailm! Kes sa oled?";

int stringLength = hello.Length;



hello = hello.Trim();
char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
firstLetter = hello[0];

Console.WriteLine(firstLetter);
Console.WriteLine(hello);   

//int wordCounter = 1;

//for(int i = 0;i < hello.Length; i++)
//{
//    //Console.WriteLine($"{i}. sümbol stringis : { hello[i]}");
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }

//}

//Console.WriteLine($"Sõnu stringis: {wordCounter}");

//Console.WriteLine(stringLength);
