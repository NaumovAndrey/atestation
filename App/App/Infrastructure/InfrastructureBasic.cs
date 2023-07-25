using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    internal class InfrastructureBasic : IInfrastructure
    {
        public int GetIntAnswer()
        {
            string str = GetStringAnswer();
            if (Int32.TryParse(str, out int result)) return result;
            return -1;
        }

        public string GetStringAnswer()
        {
            return Console.ReadLine();
        }
        public string CheckDate(int year, int month, int day)
        {
            string result = String.Empty;
            if (year > 1900 &&
                    month > 0 && month <= 12 &&
                    day > 0 && day < 31)
            {
                DateTime date = new DateTime(year, month, day);
                if (date <= DateTime.Now)
                {
                    result = date.ToShortDateString();
                }
            }
            return result;
        }
    }
}