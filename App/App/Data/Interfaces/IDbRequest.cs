using App.Model.AbstractClasses;
using App.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces
{
    internal interface IDbRequest
    {
        public List<Animal> GetAllAnimals();
        public Animal GetAnimalById(int id);
        public bool UpdateAnimal(Animal animal);
        public bool DeleteAnimal(int id);
        public List<Animal> GetAllCats();
        public List<Animal> GetAllDogs();
        public List<Animal> GetAllHamsters();
        public List<Animal> GetAllHorses();
        public List<Animal> GetAllCamels();
        public List<Animal> GetAllDonkeys();
        public bool AddAnimal(Animal animal);

    }
}