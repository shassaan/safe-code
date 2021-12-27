using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace safe_code_demo
{
    [Command("start")]
    public class Command : ICommand
    {
        [CommandOption("input-file", 'f', Description = "file name", IsRequired = true)]
        public FileInfo? File { get; set; }
        public async ValueTask ExecuteAsync(IConsole console)
        {
            var inputLines = await System.IO.File.ReadAllLinesAsync(File?.Name!);
            var output = new List<string>();
            foreach (var line in inputLines)
            {
                var splits = line.Split(";");
                var outputString = $"{splits[0]} {splits[1]},{splits[2]}";
                output.Add(outputString);
                Console.WriteLine(outputString);

            }
            System.IO.File.AppendAllLines("output.csv", output);
        }
    }
}