using Newtonsoft.Json;

namespace MyErp.Application.Models;

public record Order(int Id, Customer Customer)
{
    [JsonProperty("id")]
    public int Id = Id;

    public Customer Customer = Customer;
}