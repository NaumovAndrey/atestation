using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.AbstractClasses
{
    internal abstract class PackAnimal : Animal
    {
        public abstract override string Say();
        public abstract string CarryLoad();
    }
}