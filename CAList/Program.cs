// See https://aka.ms/new-console-template for more information

using CAList;
using System.ComponentModel;

var egypt = new Country { ISOCode = "EGY", Name = "Egypt" };
var jordan = new Country { ISOCode = "JOR", Name = "Jordan" };
var iraq = new Country { ISOCode = "IRQ", Name = "Iraq" };

Country[] countriesArray =
{
    egypt,
    jordan,
    iraq
};

// Constructors
List<Country> countries = new List<Country>();
Print(countries);   // 0, 0
// Methods
countries.Add(new Country {ISOCode = "BRA", Name = "Brasil" });   // O(1) -> Add object at the last list;   
countries.AddRange(countriesArray);
Print(countries);   // 4, 4
countries.Insert(1, new Country { ISOCode = "FRA", Name = "France" });  // O(n) Cost, High Complexity
Print(countries);   // 5, 8
countries.RemoveAt(1);
Print(countries);   // 4, 8
countries.RemoveAll(x => x.Name.EndsWith("il"));   // -> remove countries with the last 'il'
Print(countries);   // 3, 8
countries.Remove(new Country { ISOCode = "IRQ", Name = "Iraq" });  // must override of GetHashCode,Equals
Print(countries);   // 2, 8
Console.ReadKey();  
void Print(List<Country> countries)
{
    // Properties

    foreach (var c in countries)
    {
        Console.WriteLine(c);
    }

    Console.WriteLine($"Count: {countries.Count}");         // actual count
    Console.WriteLine($"Capasity: {countries.Capacity}");   // initial Capacity for inner data structure

}















