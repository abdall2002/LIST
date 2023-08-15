﻿// See https://aka.ms/new-console-template for more information

using CALinkedlists;

var lesson1 = new YTVideo { Id = "YTV1", Title = "Variables", Duration = new TimeSpan(00, 30, 00) };
var lesson2 = new YTVideo { Id = "YTV2", Title = "Classes and Strcts", Duration = new TimeSpan(01, 20, 00) };
var lesson3 = new YTVideo { Id = "YTV3", Title = "Expressions", Duration = new TimeSpan(00, 45, 00) };
var lesson4 = new YTVideo { Id = "YTV4", Title = "Iterations", Duration = new TimeSpan(01, 10, 00) };
var lesson5 = new YTVideo { Id = "YTV5", Title = "Generics", Duration = new TimeSpan(00, 20, 00) };


LinkedList<YTVideo> playlist = new LinkedList<YTVideo>(new YTVideo[] {
    lesson1,
    lesson2,
    lesson3,
    lesson4,
    lesson5
});
Print("C# from zero to hero", playlist);
Console.ReadKey();
void Print(string title, LinkedList<YTVideo> playlist)
        {
    Console.WriteLine($"┌{title}");
    foreach (var item in playlist)
        Console.WriteLine(item);
    Console.WriteLine($"└");
    Console.WriteLine($"Total: {playlist.Count} item(s)");

}









