using Newtonsoft.Json;

namespace MyErp.DAL;

public class Customer
{
    [JsonProperty("name")]
    private string _name;
    public Customer(string Name)
    {
        _name = Name;
    }
}