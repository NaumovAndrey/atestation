using App.Model.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Basic
{
    internal class Hamster : Pet
    {
        public override string Play()
        {
            return $"{Name} играет в колесе";
        }

        public override string Say()
        {
            return $"{Name} произносит свой звук";
        }

        public override string ToString()
        {
            return base.ToString() + $"Вид: Хомяк";
        }
    }
}