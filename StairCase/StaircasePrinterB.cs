using PruebaTecnica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.StairCase
{
    public class StaircasePrinterB: IStaircasePrinter
    {
        public string PrintStaircase(int n)
        {
            StringBuilder staircase = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', i - 1);
                string symbols = new string('#', n - i + 1);

                staircase.AppendLine(spaces + symbols);
            }

            return staircase.ToString();
        }
    }
}
