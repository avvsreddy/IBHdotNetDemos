using System;
using System.Configuration;

namespace POSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorFactory factory = TaxCalculatorFactory.Instance;
            //TaxCalculatorFactory tactory2 = TaxCalculatorFactory.Instance;

            //Console.WriteLine($"Factory 1 {factory1.GetHashCode()}");
            //Console.WriteLine($"Factory 2 {tactory2.GetHashCode()}");

            ITaxCalculator tax = factory.CreateTaxCalculator();
            BillingSystem billingSystem = new BillingSystem(tax);
            billingSystem.GenerateBill();
        }
    }


    public class TaxCalculatorFactory
    {

        TaxCalculatorFactory()
        {

        }

        public static readonly TaxCalculatorFactory Instance = new TaxCalculatorFactory();

        public ITaxCalculator CreateTaxCalculator()
        {
            ITaxCalculator tax = null;
            // read the config file
            string className = ConfigurationManager.AppSettings["CALC"];
            // use reflextion 
            Type theType = Type.GetType(className);
            tax = (ITaxCalculator)Activator.CreateInstance(theType);


            return tax;
        }
    }

    class BillingSystem
    {
        ITaxCalculator tax = null;

        // ctor
        public BillingSystem()
        {
            tax = new KATaxCalculator();
        }

        public BillingSystem(ITaxCalculator tax)
        {
            this.tax = tax;
        }
        // property
        // method
        public void GenerateBill()
        {
            // scan all the barcodes
            // calculate the total
            double totalAmount = 4530.00;
            // calculate the discounts
            double discAmt = 120;
            // calculate the tax
            // = new KLTaxCalculator();
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


    public class USTaxCalculator
    {
        public float ComputeTax(float amt)
        {
            //asdfsdfsdfsdf/
            //sdfsdfsdfsdfsd
            return 12.5f;
        }
    }

    public class USTaxCalculatorAdaptor : ITaxCalculator
    {
        public double CalculateTax(double amt)
        {
            System.Console.WriteLine("Using US Tax Calculator");
            USTaxCalculator uSTax = new USTaxCalculator();
            float amount = (float)amt;
            float tax = uSTax.ComputeTax(amount);
            return (double)tax;
        }
    }
}