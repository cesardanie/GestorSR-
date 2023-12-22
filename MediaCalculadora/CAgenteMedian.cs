using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Interface;

namespace PruebaTecnica.MediaCalculadora
{
    public class CAgenteMedian:IMediaCalculator
    {
        // Implementación específica para obtener la mediana
        public double GetMedia(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return 0; // Devolver 0 si la lista está vacía o es nula
            }
            numbers.Sort();
            int n = numbers.Count;
            if (n % 2 == 0)
            {
                int middle1 = n / 2 - 1;
                int middle2 = n / 2;
                return (numbers[middle1] + numbers[middle2]) / 2.0;
            }
            else
            {
                return numbers[n / 2];
            }
        }
    }
}
