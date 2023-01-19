//temp <= 0 - Külm on
//temp >0 AND temp <= 10 - Sulab, aga külm on
//temp > 10 ANDtemp <= 15 - Jahe
//temp > 15 AND temp < 20 - lühkarid
//temp >= 20 AND temp < 30 - sosu
//temp >= 30 - Saun

Console.WriteLine("Sisesta temperatuur: ");
int temp = Int32.Parse(Console.ReadLine());


if(temp >= 30)
{
    Console.WriteLine("Saunamaja");
}
else if(temp < 30 && temp >= 20)
{
    Console.WriteLine(" Hea soe !");
}
else if(temp > 15 && temp < 20)
{
    Console.WriteLine("Lühkari hooaeg, yay!");
}
else if(temp > 10 && temp <= 15)
{
    Console.WriteLine("Jahe");
}
else if(temp >0 && temp <= 10)
{
    Console.WriteLine("Sulab");
}
else //if(temp <= 0)
{
    Console.WriteLine("Ei lähe täna välja");
}
