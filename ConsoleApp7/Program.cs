using System;

namespace KalkylatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            int First = 0; // Первая переменная
            int Second = 0; // Вторая переменная
            int Answer = 0; // Ответ
            int Deustvie = 0;// Действие, которое будет выбирать пользователь

            int Cik = 0; // Переменная, которая у нас будет отвечать за цикл программы


            while (Cik == 0) // Бесконечный цикл, который будет работать до тех пор пока переменная Cik не изменит значение
            {
                Console.WriteLine("Какое Действие выполним?");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возвести в степень");
                Console.WriteLine("6. Высчитать квадратный корень числа");
                Console.WriteLine("7. Найти 1% числа");
                Console.WriteLine("8. Найти факториал числа");
                Console.WriteLine("9. Закончить");

                Deustvie = Convert.ToInt32(Console.ReadLine()); // Запрашиваем выбор действия
                switch (Deustvie)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число!");
                            Second = Convert.ToInt32(Console.ReadLine());
                            Answer = First + Second;
                            Console.Clear();
                            Console.WriteLine(First + " + " + Second + " = " + Answer);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите первое число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число!");
                            Second = Convert.ToInt32(Console.ReadLine());
                            Answer = First - Second;
                            Console.Clear();
                            Console.WriteLine(First + " - " + Second + " = " + Answer);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите первое число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число!");
                            Second = Convert.ToInt32(Console.ReadLine());
                            Answer = First * Second;
                            Console.Clear();
                            Console.WriteLine(First + " * " + Second + " = " + Answer);

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите первое число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число!");
                            Second = Convert.ToInt32(Console.ReadLine());
                            if (Second != 0)
                            {
                                Answer = First / Second;
                                Console.Clear();
                                Console.WriteLine(First + " / " + Second + " = " + Answer);
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("На 0 делитть нельзя");
                            }

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите первое число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число!");
                            Second = Convert.ToInt32(Console.ReadLine());

                            int VSP = 0;
                            int VSP1 = First;
                            for (int i = 1; i < Second; i++)
                            {
                                VSP = VSP1 * First;
                                Answer = VSP;
                                VSP1 = Answer;
                            }
                            Console.Clear();
                            Console.WriteLine(First + " в степени " + Second + " = " + Answer);

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите число!");
                            First = Convert.ToInt32(Console.ReadLine());

                            Answer = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(First)));
                            Console.Clear();
                            Console.WriteLine("Корень из числа " + First + " = " + Answer);

                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Введите число!");
                            decimal frst;
                            frst = Convert.ToDecimal(Console.ReadLine());

                            decimal Answ;
                            Answ = frst / 100;
                            Console.Clear();
                            Console.WriteLine("1% числа " + frst + " = " + Answ);

                            break;
                        }
                    case 8:
                        {
                            int fac = 1;
                            Console.WriteLine("Введите число!");
                            First = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= First; i++)
                                fac *= i;
                            Console.Clear();
                            Console.WriteLine("Факториал из числа " + First + " = " + fac);

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Приятно было поработать!");
                            Cik++;
                            break;
                        }
                }

            }
        }
    }
}