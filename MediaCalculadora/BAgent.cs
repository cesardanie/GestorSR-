using PruebaTecnica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.MediaCalculadora
{
    public class BAgent:IMediaCalculator
    {
        public double GetMedia(List<double> numbers)
        {
            // Implementación específica para obtener la media armónica
            return numbers.Count > 0 ? numbers.Count / numbers.Sum(x => 1 / x) : 0;
        }
    }
}
