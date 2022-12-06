namespace POSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillingSystem billingSystem = new BillingSystem();
            billingSystem.GenerateBill();
        }
    }


    class BillingSystem
    {
        public void GenerateBill()
        {
            // scan all the barcodes
            // calculate the total
            double totalAmount = 4530.00;
            // calculate the discounts
            double discAmt = 120;
            // calculate the tax
            ITaxCalculator tax = new KLTaxCalculator();
            double taxAmt = tax.CalculateTax(totalAmount);
            // calculate the final bill amount
            double billAmt = totalAmount + taxAmt - discAmt;
            // generate the bill
            // .....
        }
    }

    public interface ITaxCalculator
    {
        double CalculateTax(double amt);
    }

    public class KATaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amt)
        {
            double tax = 0;
            Console.WriteLine("Using KA tax calculator...");
            int cst = 120;
            int kst = 100;
            int es = 20;
            int sbt = 25;

            tax = cst + kst + es + sbt;
            return tax;
        }
    }

    public class TNTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amt)
        {
            double tax = 0;
            Console.WriteLine("Using TN Tax Calculator");
            int cst = 120;
            int tst = 105;
            int st = 25;
            int at = 25;
            tax = cst + tst + st + at;
            return tax;
        }
    }

    public class KLTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amt)
        {
            Console.WriteLine("Using Kerala Tax Calculator");
            double tax = 234;
            return tax;
        }
    }


}