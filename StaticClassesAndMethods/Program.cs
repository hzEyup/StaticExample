namespace StaticClassesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Config.ConnectionString = "constr";
            Config.SayHello();
            if (!StringUtil.Validate(""))
                Console.WriteLine("boş");
            StringUtil util = new StringUtil();
            int uzunluk = util.Lenght("Aşil");
            Console.WriteLine(uzunluk);


        }
    }//heap memory, stack memory, queue
    public static class Config
    {
        public static string ConnectionString { get; set; }
        public static string SayHello()
        {
            return "Hello Eyyyübi ";
        }
    }
    public class StringUtil
    {

        public static bool Validate(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
        public int Lenght(string value)
        {
            return value.Length;
        }
    }
}
// Ortak erişilen yerlerde kullanılır. Ender durumlarda görülür. Üstteki ygibi yapılırsa gg :D