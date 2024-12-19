using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option (1-10): ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // Использование StackArray
                    break;
                case "2":
                    // Использование QueueLinkedList
                    break;
                case "3":
                    // Проверка на палиндром
                    break;
                case "4":
                    // Оценка обратной польской нотации
                    break;
                case "5":
                    // Переворачивание массива
                    break;
                case "6":
                    // Сортировка стека
                    break;
                case "7":
                    // Стек с минимальным элементом
                    break;
                case "8":
                    // Проверка скобок
                    break;
                case "9":
                    // Использование DequeArray
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}