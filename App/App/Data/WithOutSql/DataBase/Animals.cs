using App.Model.AbstractClasses;
using App.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.WithOutSql.DataBase
{
    internal class Animals
    {
        public List<Animal> AnimalList { get; set; } = new List<Animal>()
        {
            new Cat(){Id = 1, Name = "Барсик", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.11.2020"},
            new Cat(){Id = 2, Name = "Том", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.11.2022"},
            new Dog(){Id = 3, Name = "Шарик", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.11.2020"},
            new Dog(){Id = 4, Name = "Джек", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.09.2022"},
            new Hamster(){Id = 5, Name = "Стив", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.11.2022"},
            new Hamster(){Id = 6, Name = "Родж", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.12.2022"},
            new Horse(){Id = 7, Name = "Роза", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.11.2015"},
            new Horse(){Id = 8, Name = "Белка", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.12.2021"},
            new Camel(){Id = 9, Name = "Сопатый", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "07.11.2016"},
            new Camel(){Id = 10, Name = "Лохматый", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "08.12.2022"},
            new Donkey(){Id = 11, Name = "Иа", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "05.11.2018"},
            new Donkey(){Id = 12, Name = "Рав", Commands = new List<string>(){"Сидеть", "Лежать" }, DateOfBirthday = "01.01.2022"}
        };
    }
}