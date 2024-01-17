using Newtonsoft.Json;

namespace MyErp.DAL;

public class Order
{
    [JsonProperty("id")]
    private int _id;

    public Order(int Id)
    {
        _id = Id;
    }
}