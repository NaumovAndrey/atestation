using App.Model.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Basic
{
    internal class Dog : Pet
    {
        public override string Play()
        {
            return $"{Name} играет с мячиком";
        }

        public override string Say()
        {
            return $"{Name} говорит гав";
        }
        public override string ToString()
        {
            return base.ToString() + $"Вид: Собака";
        }
    }
}