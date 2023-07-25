using App.Controller.Interfaces;
using App.Data.Interfaces;
using App.Data.WithOutSql;
using App.Infrastructure.Interfaces;
using App.Infrastructure;
using App.View.Interfaces;
using App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model.AbstractClasses;
using App.Model.Basic;

namespace App.Controller
{
    internal class ControllerBasic : IController
    {
        IDbRequest db;
        IInfrastructure infrastructure;
        IView view;
        public ControllerBasic(IDbRequest db, IInfrastructure infrastructure, IView view) 
        {
            this.db = db;
            this.infrastructure = infrastructure;
            this.view = view;
        }

        public void RunMainMenu()
        {
            while (true)
            {
                view.ShowMainMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0: 
                        return;
                    case 1:
                        RunAnimalMenu();
                        break;
                    case 2:
                        RunAddMenu();
                        break;
                    case 3:
                        RunCommandsMenu();
                        break;
                    case 4:
                        RunAddCommandMenu();
                        break;
                    case 5:
                        RunRemoveMenu();
                        break;
                    default:
                        view.ShowError();
                        break;
                }
            }
        }
        private void RunAnimalMenu()
        {
            while (true)
            {
                List<Animal> list = null;
                view.ShowAnimalMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return;
                    case 1:
                        list = db.GetAllAnimals();
                        break;
                    case 2:
                        list = db.GetAllCats();
                        break;
                    case 3:
                        list = db.GetAllDogs();
                        break;
                    case 4:
                        list = db.GetAllHamsters();
                        break;
                    case 5:
                        list = db.GetAllHorses();
                        break;
                    case 6:
                        list = db.GetAllCamels();
                        break;
                    case 7:
                        list = db.GetAllDonkeys();
                        break;
                    case 8:
                        int id = GetInt("Введите ID животного");
                        list = new List<Animal>();
                        Animal animal = db.GetAnimalById(id);
                        if (animal != null) list.Add(animal);
                        break;
                    default:
                        view.ShowError();
                        break;
                }
                if (list != null && list.Count > 0) list.ForEach(a => view.ShowText(a.ToString()));
                else if (list != null && list.Count == 0) view.ShowText("Животных не найдено");
                else view.ShowError();
            }
        }
        private void RunAddMenu()
        {
            string name = string.Empty;
            string birthday = string.Empty;
            List<string> commands = new List<string>();
            Animal animal = null;
            while (true)
            {
                view.ShowAddMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return;
                    case 1:
                        name = GetAnswer("Введите имя животного");
                        break;
                    case 2:
                        birthday = GetDate();
                        break;
                    case 3:
                        commands.Add(GetAnswer("Введите команду которую знает животное"));
                        break;
                    case 4:
                        animal = GetAnimal();
                        break;
                    case 5:
                            if (TryAddAnimalData(name, birthday, commands, animal))
                            {
                                db.AddAnimal(animal);
                                view.ShowSuccessMessage();
                            }
                            else
                            {
                                view.ShowText("Не все данные корректно введены");
                            }
                        break;
                    default:
                        view.ShowError();
                        break;
                }
            }
        }
        private void RunCommandsMenu()
        {
            while (true)
            {
                view.ShowCommandsMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return;
                    case 1:
                        answer = GetInt("Введите ID животного");
                        Animal animal = db.GetAnimalById(answer);
                        if (animal != null)
                        {
                            StringBuilder commands = new StringBuilder();
                            animal.Commands.ForEach(c => commands.Append($"{c}; "));
                            view.ShowText($"{animal.Name} знает команды {commands}");
                        }
                        else
                        {
                            view.ShowError();
                        }
                        break;
                    default:
                        view.ShowError();
                        break;
                }
            }
        }
        private void RunAddCommandMenu()
        {
            List<string> commands = new List<string>();
            Animal animal = null;
            while (true)
            {
                view.ShowAddCommandMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return;
                    case 1:
                        int id = GetInt("Введите ID животного");
                        animal = db.GetAnimalById(id);
                        if (animal != null) view.ShowText($"Животное найдено:\n{animal}");
                        break;
                    case 2:
                        commands.Add(GetAnswer("Введите команду которую знает животное"));
                        break;
                    case 3:
                        if(commands.Count > 0 && animal != null)
                        {
                            commands.ForEach(c => animal.Commands.Add(c));
                            db.UpdateAnimal(animal);
                            view.ShowSuccessMessage();
                        }
                        else
                        {
                            view.ShowError();
                        }
                        break;
                    default:
                        view.ShowError();
                        break;
                }
            }
        }
        private void RunRemoveMenu()
        {
            Animal animal = null;
            while (true)
            {
                view.ShowRemoveMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return;
                    case 1:
                        int id = GetInt("Введите ID животного");
                        animal = db.GetAnimalById(id);
                        if (animal != null) view.ShowText($"Животное найдено:\n{animal}");
                        break;
                    case 2:
                        if (animal != null)
                        {
                            db.DeleteAnimal(animal.Id);
                            view.ShowSuccessMessage();
                            animal = null;
                        }
                        else
                        {
                            view.ShowError();
                        }
                        break;
                    default:
                        view.ShowError();
                        break;
                }
            }
        }
        private Animal GetAnimal()
        {
            Animal animal = null;
            while (true)
            {
                view.ShowAnimalTypeMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return animal;
                    case 1:
                        animal = new Cat();
                        break;
                    case 2:
                        animal = new Dog();
                        break;
                    case 3:
                        animal = new Hamster();
                        break;
                    case 4:
                        animal = new Horse();
                        break;
                    case 5:
                        animal = new Camel();
                        break;
                    case 6:
                        animal = new Donkey();
                        break;
                    default:
                        view.ShowError();
                        break;
                }
                if(animal != null) return animal;
            }

        }
        private string GetDate()
        {
            string result = string.Empty;
            int year = 0;
            int month = 0;
            int day = 0;
            while (true)
            {
                view.ShowText("Введите год рождения");
                year = infrastructure.GetIntAnswer();
                view.ShowText("Введите месяц рождения");
                month = infrastructure.GetIntAnswer();
                view.ShowText("Введите день рождения");
                day = infrastructure.GetIntAnswer();
                result = infrastructure.CheckDate(year, month, day);
                if (result != string.Empty) return result;
                view.ShowError();
                view.ShowExitMenu();
                int answer = infrastructure.GetIntAnswer();
                switch (answer)
                {
                    case 0:
                        return result;
                }
            }
        }
        private string GetAnswer(string request)
        {
            view.ShowText(request);
            return infrastructure.GetStringAnswer();
        }
        private int GetInt(string request)
        {
            view.ShowText(request);
            return infrastructure.GetIntAnswer();
        }
        private bool TryAddAnimalData(string name, string birthday, List<string> commands, Animal animal)
        {
            if(name == string.Empty || birthday == string.Empty || commands.Count == 0 || animal == null) return false;
            else
            {
                animal.Name = name;
                animal.DateOfBirthday = birthday;
                animal.Commands = commands;
            }
            return true;
        }
    }
}