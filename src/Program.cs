
using System.Text;

var inputLines = File.ReadAllLines("input.txt");
var output = new List<string>();
foreach (var line in inputLines)
{
    var splits = line.Split(";");
    output.Add($"{splits[0]} {splits[1]},{splits[2]}");
    
}
File.AppendAllLines("output.csv",output);



