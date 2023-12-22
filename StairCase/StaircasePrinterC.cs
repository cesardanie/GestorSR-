using PruebaTecnica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.StairCase
{
    public class StaircasePrinterC: IStaircasePrinter
    {
        public string PrintStaircase(int n)
        {
            {
                if (n <= 0 || n >= 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(n), "El tamaño de la escalera debe estar en el rango 0 < n < 100.");
                }

                StringBuilder staircase = new StringBuilder();

                // Imprimir la parte superior de la escalera
                for (int i = 1; i <= n; i += 2)
                {
                    string spacesBefore = new string(' ', (n - i) / 2);
                    string symbols = new string('#', i);

                    staircase.AppendLine(spacesBefore + symbols);
                }

                // Imprimir la parte inferior de la escalera
                for (int i = n - 2; i > 0; i -= 2)
                {
                    string spacesBefore = new string(' ', (n - i) / 2);
                    string symbols = new string('#', i);

                    staircase.AppendLine(spacesBefore + symbols);
                }

                return staircase.ToString();
            }
        }
    }
}
