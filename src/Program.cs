
using System.Text;

var inputLines = File.ReadAllLines("input.txt");
var output = new List<string>();
foreach (var line in inputLines)
{
    var splits = line.Split(";");
    var outputString = $"{splits[0]} {splits[1]},{splits[2]}";
    output.Add(outputString);
    Console.WriteLine(outputString);
    
}
File.AppendAllLines("output.csv",output);



