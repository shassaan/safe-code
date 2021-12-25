using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using safe_code_demo.Classes;

namespace safe_code_demo.Extensions
{
    public static class DataPipeline
    {
        public static async IAsyncEnumerable<string> Extract(this string fileName)
        {
            var lines = await File.ReadAllLinesAsync(fileName);
            foreach (var line in lines)
            {
                yield return line;
            }
        }

        public static OutputObject Transform(this string line)
        {
            var splits = line.Split(";");
            var outputObject = new OutputObject
            {
                FirstName = splits[0],
                LastName = splits[1],
                PhoneNumber = splits[2]
            };
            return outputObject;
        }

        public static void Load(this OutputObject outputObject,string fileName)
        {
            
        }
    }
}