
var name = "Ewa";
var sex = "woman";
var age = 33;
if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (sex != "woman" && age < 18)  //staromodnie zakładam, że sa 2 płcie
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (name == "Ewa" && age == 33 && sex == "woman")
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("sekwencja autodestrukcji uruchomiona");
}