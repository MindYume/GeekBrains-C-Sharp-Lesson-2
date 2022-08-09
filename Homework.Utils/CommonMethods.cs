using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Utils
{
    /// <summary>
    /// Данный класс содержит методы, которые часто используются при написании программ
    /// </summary>
    public class CommonMethods
    {
        /// <summary>
        /// Выводит в консоли номер урока, номер домашней работы, описание задачи и имя студента
        /// </summary>
        /// <param name="lessonNumber">Номер урока</param>
        /// <param name="homeworkNumber">Номер домашней работы</param>
        /// <param name="taskDescription">Описание задачи в домашней работе</param>
        /// <param name="studentName">Имя студента</param>
        public static void printTaskInfo(int lessonNumber, int homeworkNumber, string taskDescription, string studentName)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Номер урока: {lessonNumber}");
            Console.WriteLine($"Номер домашней работы: {homeworkNumber}");
            Console.WriteLine($"Описание задачи: \n\t{taskDescription}");
            Console.WriteLine();
            Console.WriteLine($"Студент: {studentName}");
            Console.WriteLine("=====================================================");
            Console.WriteLine();
        }

        /// <summary>
        /// Запрашивает у пользователся ввод данных в консоли
        /// </summary>
        /// <param name="message">Сообщение, которое будет выведено перед тем, как пользователь сможет ввести данные</param>
        /// <returns></returns>
        public static string askInfo(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Приостанавливает выполнение программы
        /// </summary>
        /// <param name="message">Сообщение, которое будет выведено в консоли во время паузы</param>
        public static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        /// <summary>
        /// Приостанавливает выполнение программы
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
