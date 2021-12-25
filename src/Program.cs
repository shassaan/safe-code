
using System.Text;

var inputLines = File.ReadAllLines("input.txt");
var jsonBuilder = new StringBuilder();
jsonBuilder.Append("[");
foreach (var line in inputLines)
{
    var splits = line.Split(";");
    jsonBuilder.Append("{");
    jsonBuilder.Append($"\"firstName\":\"{splits[0]}\",");
    jsonBuilder.Append($"\"lastName\":\"{splits[1]}\",");
    jsonBuilder.Append($"\"phoneNumber\":\"{splits[2]}\"");
    jsonBuilder.Append("},");
}
jsonBuilder.Append("]");
File.WriteAllText("output.json",jsonBuilder.ToString());



