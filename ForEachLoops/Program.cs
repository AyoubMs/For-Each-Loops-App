


string data = "tim,sue,bob,jane";
List<string> firstNames = data.Split(',').ToList();

foreach (var firstName in firstNames)
{
    Console.WriteLine(firstName);
}