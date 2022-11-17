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
}