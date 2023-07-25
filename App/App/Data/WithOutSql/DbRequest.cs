using App.Data.Interfaces;
using App.Data.WithOutSql.DataBase;
using App.Model.AbstractClasses;
using App.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.WithOutSql
{
    internal class DbRequest : IDbRequest
    {
        private int currentMaxId = 0;
        private Animals animals;

        public DbRequest()
        {
            animals = new Animals();
            currentMaxId = GetMaxId();
        }

        private int GetMaxId()
        {
            animals.AnimalList.Sort();
            return animals.AnimalList.Last().Id;
        }

        public List<Animal> GetAllAnimals()
        {
            return animals.AnimalList;
        }

        public Animal GetAnimalById(int id)
        {
            return animals.AnimalList.FirstOrDefault(a => a.Id == id);
        }

        public bool UpdateAnimal(Animal animal)
        {
            for(int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i].Id == animal.Id)
                {
                    animals.AnimalList[i] = animal;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteAnimal(int id)
        {
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i].Id == id)
                {
                    animals.AnimalList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Animal> GetAllCats()
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Cat cat) result.Add(cat);
            }
            return result;
        }

        public List<Animal> GetAllDogs()
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Dog dog) result.Add(dog);
            }
            return result;
        }

        public List<Animal> GetAllHamsters()
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Hamster hamster) result.Add(hamster);
            }
            return result;
        }

        public List<Animal> GetAllHorses()
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Horse horse) result.Add(horse);
            }
            return result;
        }

        public List<Animal> GetAllCamels()
        {
            List<Animal> result = new List<Animal>();
            for(int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Camel camel) result.Add(camel);
            }
            return result;
        }

        public List<Animal> GetAllDonkeys()
        {
            List<Animal> result = new List<Animal>();
            for (int i = 0; i < animals.AnimalList.Count; i++)
            {
                if (animals.AnimalList[i] is Donkey donkey) result.Add(donkey);
            }
            return result;
        }
        public bool AddAnimal(Animal animal)
        {
            if (animal.Id != 0) return false;
            animal.Id = ++currentMaxId;
            animals.AnimalList.Add(animal);
            return true;
        }
    }
}