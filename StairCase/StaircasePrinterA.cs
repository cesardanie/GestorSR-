using PruebaTecnica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.StairCase
{
    public class StaircasePrinterA: IStaircasePrinter
    {
        public string PrintStaircase(int n)
        {
            StringBuilder staircase = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string symbols = new string('#', i);

                staircase.AppendLine(spaces + symbols);
            }

            return staircase.ToString();
        }
    }
}
