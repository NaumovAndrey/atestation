using App.Model.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Basic
{
    internal class Horse : PackAnimal
    {
        public override string CarryLoad()
        {
            return $"Лошадь {Name} несет груз";
        }

        public override string Say()
        {
            return $"{Name} говорит Иго-го";
        }
        public override string ToString()
        {
            return base.ToString() + $"Вид: Лошадь";
        }
    }
}