using System;

namespace Road
{
    class Program
    {
        static bool _isConversationWithTramp = false;

        static string _selection_1 = "Поговорить с бродягой",
                      _selection_2 = "Осмотреть окрестности";
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Для старта нажви ENTER");

            // Программа выполняется пока не будет нажата клавиша ESC
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine($"\nВы на дороге. Выберите действие:\n1 - {_selection_1}\n2 - {_selection_2}");

                // Проверка на правильность ввода данных
                try
                {
                    int selection = Convert.ToInt32(Console.ReadLine());

                    // Проверка на выбранный вариант
                    switch (selection)
                    {
                        case 1:
                            ConversationWithTramp(_isConversationWithTramp);
                            break;
                        case 2:
                            Environment();
                            break;
                        default:
                            Console.WriteLine("Такого варианта нету)");
                            break;
                    }

                    Console.WriteLine("\nПродолжить?\nENTER - ДА\nESC - НЕТ");

                }
                catch { Console.WriteLine("\nТакого варианта нету)\n\nПродолжить?\nENTER - ДА\nESC - НЕТ"); }
            }
        }

        public static void ConversationWithTramp(bool isConversation)
        {
            Console.WriteLine($"\nВы выбрали: {_selection_1}");

            // Проверка на разговор с Бродягой
            if (!isConversation)
            {
                Console.WriteLine("Он передает вам медальон и 50 монет. Поздравляю");
                _isConversationWithTramp = true;
            }
            else Console.WriteLine("Разговор ни к чему не привёл");
        }

        public static void Environment()
        {
            Console.WriteLine($"\nВы выбрали: {_selection_2}");

            // Вывод описания окружения
            Console.WriteLine("Вы осматриваетесь...\n" +
                "Покрытые снегом высоченные ели величественно стоят на склонах.\n" +
                "Сквозь их ветви пробиваются последние лучи солнца.\n" +
                "Небо уже начинают затягивать редкие серые тучи, но сквозь них все еще можно увидеть лазурный купол.\n" +
                "Под толстым слоем снега угадываются очертания кустов, камней и упавших деревьев.");
        }
    }
}
