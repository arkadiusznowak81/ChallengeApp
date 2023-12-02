string imie = "Ewa";
char plec = 'M';
int wiek = 19;

if (plec == 'K' && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (plec == 'M' && wiek < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Warunki zadania nie zostały spełnione");
}