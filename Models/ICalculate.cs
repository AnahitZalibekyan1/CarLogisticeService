using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal interface ICalculate
    {
        double Calculate(CalculationModel model);
    }
}
