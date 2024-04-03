using System;

class Program 
{
    static void Main(string[] args) {
    Console.Clear();
    Lectures lec = new Lectures("Obi-Wan Kenobi", 25, "Jedi Temple Policy Changes", "Interactions with younglings because of Anakin", "06-19-4099", "10:00 am");
    lec.SetAddress("Jedi Temple", "Senate District", "Galactic City", "Coruscant");
    Console.WriteLine($"\n{lec.GetStandardDetails()}");
    Console.WriteLine($"\n{lec.GetShortDescription()}");
    lec.GetFullInformation();

    System.Console.WriteLine("--------------------------------------------------------------------------");

    Receptions rec = new Receptions("baggins@underhill.sh", "111th Birthday", "Biblo Baggins 111th Birthday", "09-22-3001", "08:00 pm");
    rec.SetAddress("Bag End", "Bagshot Row", "Hobbiton", "The Shire");
    Console.WriteLine($"\n{rec.GetStandardDetails()}");
    Console.WriteLine($"\n{rec.GetShortDescription()}");
    rec.GetFullInformation();

    System.Console.WriteLine("--------------------------------------------------------------------------");

    Outdoor outdoor = new Outdoor("Two Suns", "Bacta Spa", "Spa with Boba Fett", "05-15-4150", "2:00 pm");
    outdoor.SetAddress("Mos Espa Way", "Mos Espa", "Tatooine", "Outer Rim");
    Console.WriteLine($"\n{outdoor.GetStandardDetails()}");
    Console.WriteLine($"\n{outdoor.GetShortDescription()}");
    outdoor.GetFullInformation(); 

    }
}