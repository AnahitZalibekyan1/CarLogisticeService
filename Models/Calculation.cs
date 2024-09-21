using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class Calculation : ICalculate
    {
        public double Calculate(double x, double y, double z, double p)
        {
            return x * y * z * p;
            throw new NotImplementedException();
        }
    }
}
