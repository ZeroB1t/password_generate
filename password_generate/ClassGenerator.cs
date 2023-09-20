using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generate
{
    public class Generator
    {

        Random rnd = new Random();
        public int numberOfPasswords;

        public string chars = "abcdefghijklmnopqrstuvwxyz1234567890";
        public string password = "";

        public void GeneratePass()
        {
            for (int i = 0; i < numberOfPasswords; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    password += chars[rnd.Next(0, chars.Length)];
                }
                Console.WriteLine($"#{i + 1} Сгенерированный пароль: {password}");
                password = "";
            }
        }
    }
}
