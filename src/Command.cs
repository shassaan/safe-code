using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using safe_code_demo.Exceptions;
using safe_code_demo.Extensions;

namespace safe_code_demo
{
    [Command("start")]
    public class Command : ICommand
    {

        [CommandOption("input-file", 'f', IsRequired = true, Description = "File Name")]
        public FileInfo? File { get; init; }
        public async ValueTask ExecuteAsync(IConsole console)
        {
            await startPipeLineAsync(File?.Name);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private async Task startPipeLineAsync(string? fileName)
        {
            try
            {
                await foreach (var line in fileName?.ExtractAsync()!)
                {
                    try
                    {
                        await line
                        .Transform()
                        .LoadAsync(Constants.OUTPUT_FILE_NAME);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine($"file not found {ex.FileName}");
                    }
                    catch (InvalidInputException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    catch (InvalidOutputException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"file not found {ex.FileName}");
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}