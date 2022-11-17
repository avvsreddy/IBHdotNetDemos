namespace CompanyOrdersApp
{
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
}