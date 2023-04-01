using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Add(5634, 345);// 53;
           // Console.WriteLine(res);
            Console.WriteLine("Hello world");
        }
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}