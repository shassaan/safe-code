using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using safe_code_demo.Classes;

namespace safe_code_demo.Extensions
{
    public static class DataPipeline
    {
        public static async IAsyncEnumerable<string> ExtractAsync(this string fileName)
        {
            var lines = await File.ReadAllLinesAsync(fileName);
            foreach (var line in lines)
            {
                yield return line;
            }
        }

        public static string Transform(this string line)
        {
            line.ValidateInput();
            var splits = line.Split(";");
            
            return $"{splits[0]} {splits[1]},{splits[2]}".ValidateOutput();
        }

        public static async Task LoadAsync(this string csvLine,string fileName)
        {
            await File.AppendAllTextAsync(fileName,$"\n{csvLine}");
        }
    }
}