namespace ExceptionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept 2 ints and find the sum ---loop

            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    // open db connection
                    int fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    // read and write
                    int sno = int.Parse(Console.ReadLine());
                    Calculator calc = new Calculator();
                    int sum = calc.FindSum(fno, sno);
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                    // close 
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Please enter only numbers");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please enter only small numbers");
                }

                catch (NotEvenNumberException ex)
                {
                    Console.WriteLine("Please enter only even numbers");
                }
                catch (ApplicationException ex) // catch all block
                {
                    Console.WriteLine("An Application error ofasdfsdfasdf");
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("A serrrosfsdfasdfasdf");
                }
            }



        }


    }

    /// <summary>
    /// Calculator is used for calculating basic mathematical result
    /// </summary>
    class Calculator // BL
    {
        /// <summary>
        /// Finds the sum of two ints - both numbers should be even -  both numbers should be +ve
        /// </summary>
        /// <param name="fno"></param>
        /// <param name="sno"></param>
        /// <returns></returns>
        /// <exception cref="NotEvenNumberException"></exception>
        /// <exception cref="NonPositiveNumbersException"></exception>
        public int FindSum(int fno, int sno)
        {
            //try
            //{
            // both numbers should be even
            if (fno % 2 != 0 || sno % 2 != 0)
                throw new NotEvenNumberException("Enter only even numbers");
            // both numbers should be +ve
            if (fno <= 0 || sno <= 0)
                throw new NonPositiveNumbersException();
            return fno + sno;
            //}
            //catch(Exception ex)
            {
                //?
                // convert original exp into custom ex
                // log exp
                //throw ex;
            }

        }
    }

    class NotEvenNumberException : Exception
    {
        //public NotEvenNumberException()
        //{

        //}
        //public NotEvenNumberException(string msg) : base(msg)
        //{
        //    //Message = msg;
        //}
        public NotEvenNumberException(string msg = null, Exception innerEx = null) : base(msg, innerEx)
        {

        }
    }

    class NonPositiveNumbersException : SystemException
    {
        //public NonPositiveNumbersException()
        //{

        //}
        //public NonPositiveNumbersException(string msg) : base(msg)
        //{

        //}
        public NonPositiveNumbersException(string msg = null, Exception innerEx = null) : base(msg, innerEx)
        {

        }
    }
}