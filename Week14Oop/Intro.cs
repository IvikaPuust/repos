Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of happiness is : {myDog.LevelOfHappiness}");
Console.WriteLine($"My dogs name is now {myDog.Name}.");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}
myDog.WigTail();

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;

    }
    //getter
    public string Name { get { return _name; } }
    public int LevelOfHappiness { get { return _levelOfHappiness; } }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Dog renamed successfully to {newName}!");
    }

    public void Bark()
    {        Console.WriteLine("Woof Woof");
        _levelOfHappiness++;

    }
   public void WigTail()
    {
        Console.WriteLine(" Wiggles the tail");

    }

}
