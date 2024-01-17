using MyErp.Business;
using MyErp.DAL;
using MyErp.PrintService;

var customerRepository = new CustomerRepository();
var firstCustomer = new Customer("John", "Smith");
var secondCustomer = new Customer("George", "Pappas");
customerRepository.Create(firstCustomer);
customerRepository.Create(secondCustomer);

var orderRepository = new OrderRepository();
orderRepository.Create(new Order(12345, firstCustomer));
orderRepository.Create(new Order(54321, secondCustomer));
orderRepository.Create(new Order(54321900, secondCustomer));
orderRepository.Create(new Order(54327661, secondCustomer));

var orders = orderRepository.GetAll();
var customers = customerRepository.GetAll();
Console.WriteLine("Enter customer name to take his order ids:");
var customerName = Console.ReadLine();

var orderResult = orders.Where(order => order.Customer.Name.Equals(customerName)).Select(order => order.Id).ToList();

var printingService = new PrintingService();
printingService.Print(orderResult);
//printingService.Print(customers.First());