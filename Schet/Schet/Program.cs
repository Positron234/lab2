// See https://aka.ms/new-console-template for more information
namespace program
{ 
    class Program
    {
        static void Main(string[] Args)
        {
            int a = 0, b = 0;
            string c;
            Console.WriteLine("ввести А");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввести В");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("выполнить операцию “+”");
            Console.WriteLine("выполнить операцию “-”");
            Console.WriteLine("выполнить операцию “*”");
            Console.WriteLine("выполнить операцию “/”");
            c = Console.ReadLine();  
            switch (c)
            {
                case ("*"):
                    {
                        Console.WriteLine(a * b); break;
                    }
                case ("/"):
                    {
                        Console.WriteLine(a / b); break;
                    }
                case ("+"):
                    {
                        Console.WriteLine(a + b); break;
                    }
                case ("-"):
                    {
                        Console.WriteLine(a - b); break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

    }
}