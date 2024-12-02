using System.Text.RegularExpressions;

const String filename = "./input.txt";

var list1= new List<int>();
var list2 = new List<int>();

using (StreamReader sr = new StreamReader(filename))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
      string[] parts = Regex.Split(line, @"\s+");
      list1.Add(int.Parse(parts[0]));
      list2.Add(int.Parse(parts[1]));
    }
}

var list1_s = list1.OrderBy(i => i).ToList();
var list2_s = list2.OrderBy(i => i).ToList();

var list = list1_s.Zip(list2_s, (a, b) => Math.Abs(a - b)).ToList();
int sum = list.Sum();

Console.WriteLine(sum);
