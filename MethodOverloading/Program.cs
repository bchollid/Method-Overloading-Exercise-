namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool canAdd)
        {
            if(canAdd == true)
            {
                int sum = a + b;
                if(sum == 1)
                {
                    return $"{sum} dollar.";
                }
                else if (sum > 1)
                {
                    return $"{sum} dollars.";
                }
            }
            else
            {
                return "Sorry, I can't add those numbers.";
            }
            return "Please try again.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 1));
            Console.WriteLine(Add(1.111, 1.111));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(1, 1, true));
            Console.WriteLine(Add(1, 1, false));
        }
    }
}
