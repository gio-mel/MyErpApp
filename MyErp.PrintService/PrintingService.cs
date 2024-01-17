using Newtonsoft.Json;

namespace MyErp.PrintService;

public class PrintingService
{
    public void Print<T>(T input)
    {
        Console.WriteLine(JsonConvert.SerializeObject(input));
    }
}