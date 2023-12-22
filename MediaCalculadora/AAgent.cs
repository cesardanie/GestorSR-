using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Interface;

namespace PruebaTecnica.MediaCalculadora
{
    public class AAgent:IMediaCalculator
    {
        public double GetMedia(List<double> numbers)
        {
            // Implementación específica para obtener la media aritmética
            return numbers.Count > 0 ? numbers.Sum() / numbers.Count : 0;
        }
    }
}
