using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.AbstractClasses
{
    internal abstract class Animal : IComparable<Animal>
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string DateOfBirthday { get; set; }
        public List<string> Commands { get; set; }
        public abstract string Say();
        public int CompareTo(Animal? animal) 
        {
            if (animal is null) throw new ArgumentException("Некорректное значение параметра");
                return Id - animal.Id;
        }
        public override string ToString()
        {
            StringBuilder commandsAsString = new StringBuilder();
            Commands.ForEach(c => commandsAsString.Append($"{c}; "));
            return $"Id: {Id}, Имя: {Name}, День_рождения: {DateOfBirthday}, Команды: {commandsAsString} ";
        }
    }
}