using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Interfaces
{
    internal interface IInfrastructure
    {
        public int GetIntAnswer();
        public string GetStringAnswer();
        public string CheckDate(int year, int month, int day);
    }
}