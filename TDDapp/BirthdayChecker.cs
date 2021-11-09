using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDapp
{
    public class BirthdayChecker
    {
        public static bool IsBirthdayToday(DateTime date)
        {
            return date.Month == DateTime.Now.Month && date.Day == DateTime.Now.Day;
        }
    }
}
