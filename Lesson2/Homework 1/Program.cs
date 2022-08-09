using Homework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Включение Кириллицы в консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("0 -> Выход");
                Console.WriteLine("=====================================================");

                int taskNumber = int.Parse(CommonMethods.askInfo("Введите номер задачи: "));

                switch (taskNumber)
                {
                    default:
                        Console.WriteLine("Некорректый номер задачи. Повторие ввод.");
                        break;

                    case 0:
                        runProgram = false;
                        break;

                    case 1:
                        Task1();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;

                    case 2:
                        Task2();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;

                    case 3:
                        Task3();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;

                    case 4:
                        Task4();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;

                    case 5:
                        Task5();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;

                    case 6:
                        Task6();
                        CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
                        break;
                }
            }

            CommonMethods.Pause("\nНажмите любую клавишу, чтобы выйти...");
        }


        #region Методы для вызова задачь из домашней работы

        static void Task1()
        {
            CommonMethods.printTaskInfo(2, 1, "Написать метод, возвращающий минимальное из трёх чисел", "Грачёв Виктор Алексеевич");

            int num1, num2, num3;

            num1 = int.Parse(CommonMethods.askInfo("Введите перове число: "));
            num2 = int.Parse(CommonMethods.askInfo("Введите второе число: "));
            num3 = int.Parse(CommonMethods.askInfo("Введите третье число: "));

 
            Console.WriteLine($"Максимальное число: {GetMaxNumber(num1, num2, num3)}\n");
        }

        static void Task2()
        {
            CommonMethods.printTaskInfo(2, 2, "Написать метод подсчета количества цифр числа", "Грачёв Виктор Алексеевич");

            int number = int.Parse(CommonMethods.askInfo("Введите число: "));

            Console.WriteLine($"Количество цифр в числе: {GetDigitsAmount(number)}\n");
        }

        static void Task3()
        {
            CommonMethods.printTaskInfo(
                2, 
                3, 
                "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.", 
                "Грачёв Виктор Алексеевич"
            );


            int inputNumber;
            int correctNumbersAmount = 0;

            do
            {
                inputNumber = int.Parse(CommonMethods.askInfo("Введите число: "));

                if (inputNumber > 0 && inputNumber%2 != 0)
                {
                    correctNumbersAmount++;
                }
            }
            while (inputNumber != 0);

            Console.WriteLine($"Сумма всех нечетных положительных чисел: {correctNumbersAmount}\n");
        }

        static void Task4()
        {
            CommonMethods.printTaskInfo(
                2,
                4,
                "Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль." +
                "На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains)." +
                "Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль," +
                "программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.",
                "Грачёв Виктор Алексеевич"
            );

            string login, password;
            int attempts = 3;

            do
            {
                login = CommonMethods.askInfo("Введите логин: ");
                password = CommonMethods.askInfo("Введите пароль: ");

                if (verifyLogin(login, password))
                {
                    Console.WriteLine("Вы правильно ввели логин и пароль\n");
                    break;
                }
                else
                {
                    attempts--;

                    if (attempts > 0)
                    {
                        Console.WriteLine("Вы неправильно ввели логин и пароль, попробуйте ещё раз.");
                        Console.WriteLine($"Количество оставшихся попыток: {attempts}");
                    }
                    else
                    {
                        Console.WriteLine("У вас закончились попытки ввести логин и пароль правильно.\n");
                        break;
                    }
                }
            }
            while (true);
        }

        static void Task5()
        {
            CommonMethods.printTaskInfo(
                2,
                5,
                "а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает," +
                "нужно ли человеку похудеть, набрать вес или всё в норме." +
                "\n\tб) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.",
                "Грачёв Виктор Алексеевич"
            );

            double weight = double.Parse(CommonMethods.askInfo("Введите ваш вес в килограммах: "));
            double height = double.Parse(CommonMethods.askInfo("Введите ваш рост в сантиметрах: "));

            double index = weight / Math.Pow( height / 100, 2);


            Console.WriteLine("Норма индекса массы тела от 18.5 до 25");
            Console.WriteLine($"Ваш индекс массы тела равен {index:F2}");
            if (index >= 18.5 && index <= 25)
            {
                Console.WriteLine($"У вас всё в порядке с весом");
            }
            else
            {
                if (index < 18.5)
                {
                    double watedWeight = Math.Ceiling((18.5 - index) * Math.Pow(height / 100, 2));

                    Console.WriteLine($"У вас недобор веса");
                    Console.WriteLine($"Вам необходимо добрать {watedWeight} кг для нормы");
                }
                else
                {
                    double watedWeight = Math.Ceiling((index - 25) * Math.Pow(height / 100, 2));

                    Console.WriteLine($"У есть лишний вес");
                    Console.WriteLine($"Вам необходимо похудеть на {watedWeight} кг для нормы");
                }
            }

            Console.WriteLine();

        }

        static void Task6()
        {
            CommonMethods.printTaskInfo(
                2,
                6,
                "Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. " +
                "«Хорошим» называется число, которое делится на сумму своих цифр. " +
                "Реализовать подсчёт времени выполнения программы, используя структуру DateTime.",
                "Грачёв Виктор Алексеевич"
            );


            long time = DateTime.Now.Second;
            Console.WriteLine("Количество Хороших чисел вычисляется, пожалуйста подождите");


            int goodNumbers = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % GetDigitsSum(i) == 0)
                {
                    goodNumbers++;
                }
            }

            Console.WriteLine($"Количество Хороших чисел: {goodNumbers}");
            Console.WriteLine($"Время, потраченное на вычисления: {(DateTime.Now.Second - time)} секунд\n");

        }

        #endregion


        #region Вспомогательные методы

        /// <summary>
        /// Проверяет, равен ли логин значению "root" и равен ли пароль значению "GeekBrains"
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Если логин равен значению "root" и пароль равен значению "GeekBrains", то возвращает ture, иначе false </returns>
        static bool verifyLogin(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Возвращает максимальное значение из трёх переданных чисел
        /// </summary>
        static int GetMaxNumber(int num1, int num2, int num3)
        {
            int numMax = num1;

            numMax = num2 > numMax ? num2 : numMax;
            numMax = num3 > numMax ? num3 : numMax;

            return numMax;
        }

        /// <summary>
        /// Возвращает сумму цифр введённого числа
        /// </summary>
        static int GetDigitsSum(int number)
        {
            int digitsSum = 0;

            while (number != 0)
            {
                digitsSum += number % 10;
                number /= 10;
            }

            return digitsSum;
        }

        /// <summary>
        /// Возвращает количество цифр введённого числа
        /// </summary>
        static int GetDigitsAmount(int number)
        {
            int digitsAmount = 0;

            do
            {
                number /= 10;
                digitsAmount++;
            }
            while (number != 0);

            return digitsAmount;
        }

        #endregion
    }
}
