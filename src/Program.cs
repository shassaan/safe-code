using safe_code_demo.Exceptions;
using safe_code_demo.Extensions;

try
{
    await foreach (var line in "input.txt".ExtractAsync())
    {
        try
        {
            await line
            .Transform()
            .LoadAsync("output.csv");
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
