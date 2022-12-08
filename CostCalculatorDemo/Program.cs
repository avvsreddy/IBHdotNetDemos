namespace CostCalculatorDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             * Design Patterns Lab
-------------------------------------

For a shopping cart system, develop the cost calculator
The cashier can add a Discount to the sale without prior notification.
The cashier can even deduct a Rs 50 from the sale as a consequence of purchasing bulk orders on a vacation day.
And similarly there can be any new discounts or amendments to sale in the future is possible.

Hint: Use Decorator Pattern
*/
            ICostCalculator calc = new RegularCostCalculator();
            //calc = new DiscountCostCalculator(calc);
            //calc = new SpecialSaleCostCalculator(calc);
            calc.CalculateCost(1000);


        }
    }

    public interface ICostCalculator
    {
        double CalculateCost(double amt);
    }
    public class RegularCostCalculator : ICostCalculator
    {
        public double CalculateCost(double amt)
        {
            Console.WriteLine("Regular Cost Calculator");
            double cost = amt;
            return cost;
        }
    }

    public abstract class CostCalculatorDecorator : ICostCalculator
    {
        protected ICostCalculator costCalculator;
        public CostCalculatorDecorator(ICostCalculator calc)
        {
            this.costCalculator = calc;
        }
        public virtual double CalculateCost(double amt)
        {
            return costCalculator.CalculateCost(amt);
        }
    }

    public class DiscountCostCalculator : CostCalculatorDecorator
    {

        public DiscountCostCalculator(ICostCalculator calc) : base(calc)
        {
        }
        public override double CalculateCost(double amt)
        {
            //double cost = base.CalculateCost(amt);
            Console.WriteLine("Applying discount....");
            return costCalculator.CalculateCost(amt) - 100;
        }


    }

    public class SpecialSaleCostCalculator : CostCalculatorDecorator
    {
        public SpecialSaleCostCalculator(ICostCalculator calc) : base(calc)
        {
        }
        public override double CalculateCost(double amt)
        {
            Console.WriteLine("Calculating special sale cost...");
            return base.CalculateCost(amt) - 120;
        }
    }
}