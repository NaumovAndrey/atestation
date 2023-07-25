using App.Model.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Basic
{
    internal class Donkey : PackAnimal
    {
        public override string CarryLoad()
        {
            return $"Осел {Name} несет груз";
        }

        public override string Say()
        {
            return $"{Name} говорит Иа";
        }
        public override string ToString()
        {
            return base.ToString() + $"Вид: Осел";
        }
    }
}