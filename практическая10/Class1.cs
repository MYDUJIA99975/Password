using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая10
{
    class Generator
    {
        public string num = "0123456789";
        public string letter = "AaBbCcDdEeFfGgHhIiJjKkLlVvNnOoPpQqRrSsTtUuVvWwXxYyZz";
        public string simvol = "!#$%&()*+,-./:;<=>?@[]^_{|}~";
        public int lenght;
        public int set;
        public string number;

        public void PasswordCreate()
        {
            string def = "---------------------------------------------------------------------";
            Console.WriteLine("Добро пожаловать в программу генерации паролей.");
            Console.WriteLine(def);
            Console.Write("Введите длину пароля: ");
            number = Convert.ToString(Console.ReadLine());
            Lenght();
            Console.WriteLine(def);
            Console.WriteLine("Выберите из чего будет состоять пароль:");
            Console.WriteLine("1.Только из цифр\n2.Только из букв\n3.Из цифр и букв\n4.Только из символов\n5.Из цифр и символов\n6.Из букв и символов\n7.Из букв, цифр и символов");
            Console.WriteLine(def);
            Console.Write("Ваш выбор: ");
            number = Convert.ToString(Console.ReadLine());
            Set();
            Console.WriteLine(def);
            PasswordGenerator();
        }
        private void Lenght()
        {
            string def = "---------------------------------------------------------------------";
            while (!Int32.TryParse(number, out lenght))
            {
                Console.WriteLine(def);
                Console.WriteLine("Это не число! Попробуйте заново");
                Console.WriteLine();
                Console.Write("Введите длину пароля: ");
                number = Console.ReadLine();
            }
        }
        private void Set()
        {
            string def = "---------------------------------------------------------------------";
            while (!Int32.TryParse(number, out set))
            {
                Console.WriteLine(def);
                Console.WriteLine("Это не число! Попробуйте заново");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");
                number = Console.ReadLine();
            }
        }
        private void PasswordGenerator()
        {
            Random rand = new Random();
            switch (set)
            {
                case 1:
                    int i = rand.Next(0, num.Length);
                    Console.Write($"Ваш готовый пароль: {i} ");
                    break;
            }
        }
    }
}
