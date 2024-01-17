namespace MyErp.DAL;

public static class ErpDB
{
    public static List<Order> Orders = new();
    public static List<Customer> Customers = new();
}

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }

    public Order(int id, Customer customer)
    {
        Id = id;
        Customer = customer;
    }
}

public class Customer
{
    public string Name;
    
    public string Surname;
    
    public Customer(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}