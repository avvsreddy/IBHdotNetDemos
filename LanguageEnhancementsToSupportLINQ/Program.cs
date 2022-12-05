namespace LanguageEnhancementsToSupportLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. (var) Local variable type inference 

            // extension methods

            List<int> numbers = new List<int>();


            string str = "some data";
            str.ToUpper();

            str.ToLower();
            str.Encrypt();

            str = MyUtil.Encrypt(str);
            int a = 1000;
            a.Encrypt();
            Program p = new Program();
            p.Encrypt();


        }
    }

    static class MyUtil
    {
        public static string Encrypt(this Object data)
        {
            return "@#$@#$EWFSDR@#RWER@%@#R@#%@#$%@!#%R";
        }
    }

    //class Emp
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}
}