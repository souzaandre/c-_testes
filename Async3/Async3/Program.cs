using System;
using System.Threading.Tasks;

namespace Async3
{
    class Program
    {
        public static void Main()
        {
            var result = FazAlgumaCoisa();
            Soma(10, 10);
            Multiplica(10, 10);
            Console.Read();
        }

        private static async Task FazAlgumaCoisa()
        {
            await Task.Delay(1000);
            Console.WriteLine("FazAlgumaCoisa");
        }

        private static void Soma(int num1, int num2)
        {
            Console.WriteLine("O resultado da soma é : {0} ", num1 + num2);
        }

        private static void Multiplica(int num1, int num2)
        {
            Console.WriteLine("O resultado da multiplicacao é : {0} ", num1 * num2);
        }
    }
}
