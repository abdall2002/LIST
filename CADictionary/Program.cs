// See https://aka.ms/new-console-template for more information



var article =
    "Dot NET is a free cross-platform and open source developer platform" +
    "for building many different types of applications" +
    "With Dot NET you can use multiple languages and libraries" +
    "to build for web and IoT";
// key: 'd', value: "Dot" "Developer"
Dictionary<char, List<string>> lettersDictionary = new Dictionary<char, List<string>>();
foreach (var word in article.Split())
{
    foreach(var ch in word)
    {
        char c = Char.ToLower(ch);
        if(!lettersDictionary.ContainsKey(c))
        {
            lettersDictionary.Add(c, new List<string> { word.ToLower() });
        }
        else
        {
            lettersDictionary[c].Add(word);
        }
    }
}
foreach (var entry in lettersDictionary)
{
    Console.Write($"'{entry.Key}': ");
    foreach (var word in entry.Value)
    {
        Console.WriteLine($"\t\t \"{word}\"");
    }
}

