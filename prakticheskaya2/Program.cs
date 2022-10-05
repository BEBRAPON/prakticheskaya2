using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prakticheskaya2
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Выберите одну из представленных программ:\r\n 1.Игра - Угадай число.\r\n 2.Таблица умножения.\r\n 3.Вывод делителей числа.\r\n 4.Выход из программы.");
			string programs = Console.ReadLine();
			
			switch (programs)
			{
				case "1":
					ygadayChislo();
					
				    break;
				
				case "2":
					tablicaYmnozheniya();
					
                    break;

				
				case "3":
					vivodChisel();
					
					break;
				
				case "4":
					Environment.Exit(0);
					break;
				default:
				
					Console.WriteLine("Извините, но программы под этим номером нет.\r\n");
					Program.Main();
						break;					
			}
		}
		static void ygadayChislo()
		{
            Random random = new Random();
            int randomNum = random.Next(0, 100);
            Console.WriteLine("Попробуйте угадать загаданное число.\r\nДля этого введите любое число от 0 до 100");
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 100)
                {
                    Console.WriteLine("Извините, но введённое число выходит за пределы диапазона(Загаданное число осталось без изменений, поэтому вы можете опираться на предыдущие подсказки).\r\nПовторно введите число:");

                }
                else
                    while (num != randomNum)
                    {
                        if (num > randomNum)
                        {
                            Console.WriteLine("Надо меньше");

                        }
                        if (num < randomNum)
                        {
                            Console.WriteLine("Надо больше");

                        }
                        break;

                    }
                if (num == randomNum)
                {
                    Console.WriteLine(randomNum);
                    Console.WriteLine("Вы отгадали число, поздравляю!\r\nВы переходите в главное меню.\r\n");
					Main(); 
                }
            }

        }
		static void tablicaYmnozheniya()
		{
            int[,] table = new int[11, 11];

            for (int line = 1; line < table.GetLength(0); line++)
            {
                for (int column = 1; column < table.GetLength(1); column++)
                {
                    table[line, column] = line * column;
                }

            }


            for (int line = 1; line < table.GetLength(0); line++)
            {
                for (int column = 1; column < table.GetLength(1); column++)
                {
                    Console.Write(table[line, column] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите на клавишу Enter для выхода в главное меню:\r\n ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                Console.WriteLine("Если вы хотите вернуться в главное меню, нажмите Enter:\r\n ");
			Main();
        }
		static void vivodChisel()
		{
			Console.WriteLine("Введите число: ");
            int delimoe = Convert.ToInt32(Console.ReadLine());
            for (int delitel = 1; delitel <= delimoe; delitel++)
            {
				if (delimoe % delitel == 0)
					Console.Write(delitel + " ");
            }
				Console.WriteLine("\r\nВы переходите в главное меню.\r\n");
            
            Main();
            


        }
    }
}

