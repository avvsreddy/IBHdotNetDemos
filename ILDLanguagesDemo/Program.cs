using ILDLanguagesDemo;

namespace ILDLanguagesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();

            LangCSharp cs = new LangCSharp();
            LangJava java = new LangJava();
            LangC c = new LangC();

            ide.Languages.Add(cs);
            ide.Languages.Add(java);
            ide.Languages.Add(c);
            //ide.Languages.Add(new ABCLag());

            ide.DoWork();
        }
    }

    class IDE
    {
        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();
        public void DoWork()
        {
            foreach (ILanguage language in Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
                Console.WriteLine("------------------");
            }
        }

    }


    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }


    abstract class OOLanguage : ILanguage
    {
        public string GetUnit()
        {
            return "Class";
        }
        public string GetParadigm()
        {
            return "Object Oriented";
        }

        abstract public string GetName();

    }

    abstract class ProcLanguage : ILanguage
    {
        public string GetUnit()
        {
            return "Functions";
        }
        public string GetParadigm()
        {
            return "Procedur Oriented";
        }

        abstract public string GetName();

    }

    class LangCSharp : OOLanguage
    {
        public override string GetName()
        {
            return "CSharp";
        }


    }
    class LangJava : OOLanguage
    {
        public override string GetName()
        {
            return "Java";
        }
    }

}
class LangC : ProcLanguage
{
    public override string GetName()
    {
        return "C Language";
    }


}


