using PruebaTecnica.Interface;
using PruebaTecnica.StairCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Context
{
    public class StaircasePrinterFactory
    {
        public static IStaircasePrinter GetStaircasePrinter(char agent)
        {
            switch (char.ToUpper(agent))
            {
                case 'A':
                    return new StaircasePrinterA();
                case 'B':
                    return new StaircasePrinterB();
                case 'C':
                    return new StaircasePrinterC();
                default:
                    throw new ArgumentException("Invalid agent type");
            }
        }
    }
}
