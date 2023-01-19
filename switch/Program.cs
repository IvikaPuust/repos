int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
    
    case 0:

        Console.WriteLine("Pühapäev");
        break;

    case 1:

        Console.WriteLine("Esmaspäev");
        break;

    case 2:

        Console.WriteLine("Teisipäev");
        break;

    case 3:

        Console.WriteLine("Kolmapäev");
        break;

    case 4:

        Console.WriteLine("Neljapäev");
        break;

    case 5:

        Console.WriteLine("Reede");
        break;

    case 6:

        Console.WriteLine("Laupäev");
        break;

    default:

        Console.WriteLine("Kalender ei tööta");
        break;

}
Console.WriteLine("Meeldivat päeva jätku!");



