using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Смогу объяснить каждую строку написанного мною кода :)
            Console.Write("Введите количесвтво паролей: ");

            Generator generator = new Generator();
            generator.numberOfPasswords = int.Parse(Console.ReadLine());

            generator.GeneratePass();
        }
    }
}
