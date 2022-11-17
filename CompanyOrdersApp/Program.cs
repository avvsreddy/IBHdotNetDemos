namespace CompanyOrdersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            //Customer c1 = new Customer();
            RegCustomer rc1 = new RegCustomer { SplDiscount = 10 };
            company.Customers.Add(rc1);
            Order o1 = new Order();
            rc1.Orders.Add(o1);
            OrderItem oi1 = new OrderItem { Qty = 1 };
            o1.OrderItems.Add(oi1);
            Item i1 = new Item { Rate = 1000 };
            oi1.Item = i1;

            Console.WriteLine(company.GetTotalWorthOfOrdersPlaced());
        }
    }

    class Company
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public double GetTotalWorthOfOrdersPlaced()
        {

            // calculate the total
            double total = 0;

            // for each customer
            foreach (Customer customer in Customers)
            {
                // for each order of a customer
                foreach (Order order in customer.Orders)
                {
                    // for each ordered items of each order of a customer
                    foreach (OrderItem oItem in order.OrderItems)
                    {
                        total += oItem.Qty * oItem.Item.Rate;
                    }
                }
                if (customer is RegCustomer)
                {
                    RegCustomer regCust = customer as RegCustomer;
                    double discountAmt = total * regCust.SplDiscount / 100;
                    total -= discountAmt;
                }
            }
            // calculate the discount

            return total;
        }
    }
    class Item
    {
        public int Rate { get; set; }
        public string Desc { get; set; }
    }
    class Customer
    {
        public List<Order> Orders { get; set; } = new List<Order>();


    }
    class RegCustomer : Customer
    {
        public double SplDiscount { get; set; }
    }
    class Order
    {
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
    class OrderItem
    {
        public int Qty { get; set; }
        public Item Item { get; set; }
    }
}