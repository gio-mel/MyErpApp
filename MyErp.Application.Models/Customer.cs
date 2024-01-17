using Newtonsoft.Json;

namespace MyErp.Application.Models;

public record Customer(string Name, string Surname)
{
    [JsonProperty("name")]
    public string Name = Name;
    
    [JsonProperty("surname")]
    public string Surname = Surname;
}