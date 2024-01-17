using MyErp.Business;
using MyErp.DAL;
using MyErp.PrintService;

var orderRepository = new OrderRepository();
orderRepository.Create(new Order(12345));
orderRepository.Create(new Order(54321));

var customerRepository = new CustomerRepository();
customerRepository.Create(new Customer("John"));
customerRepository.Create(new Customer("George"));

var orders = orderRepository.GetAll();
var customers = customerRepository.GetAll();

var printingService = new PrintingService();
printingService.Print(orders.First());
printingService.Print(customers.First());