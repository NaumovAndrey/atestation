using App.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.View
{
    internal class ViewForConsole : IView
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("__________________________\n"
                            + "Введите пункт меню\n"
                            + "1 - Показать животных\n"
                            + "2 - Добавить животное\n"
                            + "3 - Посмотреть команды которые выполняет животное\n"
                            + "4 - Добавить новую команду\n"
                            + "5 - Удалить животное\n"
                            + "0 - Выход из программы");
        }

        public void ShowAnimalMenu()
        {
            Console.WriteLine("__________________________\n"
                            + "Введите пункт меню\n"
                            + "1 - Показать всех животных\n"
                            + "2 - Показать всех кошек\n"
                            + "3 - Показать всех собак\n"
                            + "4 - Показать всех хомяков\n"
                            + "5 - Показать всех лошадей\n"
                            + "6 - Показать всех верблюдов\n"
                            + "7 - Показать всех ослов\n"
                            + "8 - Показать животное по ID\n"
                            + "0 - Возврат в главное меню");
        }

        public void ShowAddMenu()
        {
            Console.WriteLine("__________________________\n"
                            + "Введите пункт меню\n"
                            + "1 - Ввести имя\n"
                            + "2 - Ввести дату рождения\n"
                            + "3 - Ввести команду которую знает животное\n"
                            + "4 - Выбрать вид животного\n"
                            + "5 - Добавить животное\n"
                            + "0 - Возврат в главное меню");
        }

        public void ShowCommandsMenu()
        {
            Console.WriteLine("__________________________\n"
                + "Введите пункт меню\n"
                + "1 - Ввести ID животного\n"
                + "0 - Возврат в главное меню");
        }
        public void ShowAddCommandMenu()
        {
            Console.WriteLine("__________________________\n"
                            + "Введите пункт меню\n"
                            + "1 - Ввести ID животного\n"
                            + "2 - Ввести команду которую знает животное\n"
                            + "3 - Добавить изменения\n"
                            + "0 - Возврат в главное меню");
        }

        public void ShowRemoveMenu()
        {
            Console.WriteLine("__________________________\n"
                            + "Введите пункт меню\n"
                            + "1 - Ввести ID\n"
                            + "2 - Удалить животное\n"
                            + "0 - Возврат в главное меню");
        }
        public void ShowCheckMenu() 
        {
            Console.WriteLine("__________________________\n"
                                + "Введите пункт меню\n"
                                + "1 - Подтведить действие\n"
                                + "0 - Назад в меню\n");
        }

        public void ShowExitMenu()
        {
            Console.WriteLine("__________________________\n"
                                + "Введите 0 для возврата в предыдущее меню\n"
                                + "Для повторного ввода введите любое значение");
        }
        public void ShowAnimalTypeMenu()
        {
            Console.WriteLine("__________________________\n"
                + "Введите пункт меню\n"
                + "1 - Кошка\n"
                + "2 - Собака\n"
                + "3 - Хомяк\n"
                + "4 - Лошадь\n"
                + "5 - Верблюд\n"
                + "6 - Осел\n"
                + "0 - Возврат в главное меню");
        }
        public void ShowText(string text)
        {
            Console.WriteLine("__________________________\n" + text);
        }
        public void ShowError()
        {
            Console.WriteLine("Вы ввели некорректное значение");
        }

        public void ShowRequestData()
        {
            Console.WriteLine("Введите данные:");
        }

        public void ShowPreviewText()
        {
            Console.WriteLine("Предварительный просмотр:");
        }

        public void ShowNotFoundt()
        {
            Console.WriteLine("Данные соответствующие запросу не найдены:");
        }

        public void ShowSuccessMessage()
        {
            Console.WriteLine("Запрос успешно выполнен:");
        }
    }
}