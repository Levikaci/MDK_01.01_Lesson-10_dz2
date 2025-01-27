public abstract class Translator
{
    public abstract string GetLanguage();
}

public class EnglishTranslator : Translator
{
    public override string GetLanguage()
    {
        return "Английский"; 
    }

    public EnglishTranslator()
    {
        Console.WriteLine("Я переводчик с английского");
    }
}

public class Program
{
    public static void Main()
    {
        EnglishTranslator translator = new EnglishTranslator();
       
    }
}