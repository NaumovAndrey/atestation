using App.Model.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Basic
{
    internal class Camel : PackAnimal
    {
        public override string CarryLoad()
        {
            return $"Верблюд {Name} несет груз";
        }

        public override string Say()
        {
            return $"Верблюд {Name} произносит звук";
        }
        public override string ToString()
        {
            return base.ToString() + $"Вид: Верблюд";
        }
    }
}