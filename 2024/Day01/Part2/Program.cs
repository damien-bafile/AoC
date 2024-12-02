using System.Text.RegularExpressions;

const String filename = "./input.txt";

var list1 = new List<int>();
var list2 = new List<int>();

using (StreamReader sr = new StreamReader(filename))
{
    string? line;
    while ((line = sr.ReadLine()) != null)
    {
      string[] parts = Regex.Split(line, @"\s+");
      list1.Add(int.Parse(parts[0]));
      list2.Add(int.Parse(parts[1]));
    }
}

var list = new List<int>();

foreach (var item in list1)
{
  list.Add(item * list2.FindAll(i => i == item).Count);
}

int sum = list.Sum();

Console.WriteLine(sum);
