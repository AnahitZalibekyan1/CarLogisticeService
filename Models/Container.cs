using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class Container
    {
        public Container(int id, bool name, double coefficient)
        {
            Id = id;
            ContainerType = name;
            Coefficient = coefficient;
        }

        public Container()
        {

        }

        public int Id { get; set; }
        public bool ContainerType { get; set; }
        public double Coefficient {  get; set; }
    }
}
