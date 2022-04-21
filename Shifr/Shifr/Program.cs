using System;

namespace Shifr
{
    class Program
    {
        static char[] alphabet = {'а', 'б', 'в', 'г', 'д','е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н',
            'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. зашифровать 2. расшифровать 3. выйти");
                string temp = Console.ReadLine();
                if (temp == "3")
                {
                    break;
                }
                switch (temp)
                {
                    case "1":
                        Shifr();
                        break;
                    case "2":
                        RasShifr();
                        break;
                }
            }
        }

        static void Shifr()
        {
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            char[] messageAr = message.ToCharArray();
            char[] keyAr = key.ToCharArray();
            char[] shifr = new char[message.Length];

            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (messageAr[i] == ' ')
                {
                    shifr[i] = ' ';
                    continue;
                }
                int index = Array.IndexOf(alphabet, messageAr[i]) + Array.IndexOf(alphabet, keyAr[j]) + 1;
                if (index >= alphabet.Length)
                {
                    index -= alphabet.Length;
                }
                shifr[i] = alphabet[index];
                j++;
                if (j == keyAr.Length)
                {
                    j = 0;
                }
            }
            Console.Write("Зашифрованное сообщение: ");
            foreach (char c in shifr)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        static void RasShifr()
        {
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            char[] messageAr = message.ToCharArray();
            char[] keyAr = key.ToCharArray();
            char[] rasShifr = new char[message.Length];

            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (messageAr[i] == ' ')
                {
                    rasShifr[i] = ' ';
                    continue;
                }
                int index = Array.IndexOf(alphabet, messageAr[i]) - Array.IndexOf(alphabet, keyAr[j]) - 1;
                if (index < 0)
                {
                    index += alphabet.Length;
                }
                rasShifr[i] = alphabet[index];
                j++;
                if (j == keyAr.Length)
                {
                    j = 0;
                }
            }
            Console.Write("Расшифрованное сообщение: ");
            foreach (char c in rasShifr)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}