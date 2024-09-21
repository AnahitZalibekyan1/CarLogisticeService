using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class CrushedCar
    {
        public CrushedCar(int id, bool isCarCrushed, double coefficient)
        {
            Id = id;
            IsCarCrushed = isCarCrushed;
            Coefficient = coefficient;
        }

        public int Id { get; set; }
        public bool IsCarCrushed {  get; set; }
        public double Coefficient {  get; set; }
    }
}
