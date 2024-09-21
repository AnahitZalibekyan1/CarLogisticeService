using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class CarType
    {
        public CarType(int id, string name, double coefficient)
        {
            Id = id;
            Name = name;
            Coefficient = coefficient;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Coefficient {  get; set; }
    }
}
