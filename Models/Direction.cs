using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    public class Direction
    {
        public Direction(int id, double price, string from, string to, double distance)
        {
            Id = id;
            Price = price;
            From = from;
            To = to;
            Distance = distance;
        }

        public int Id { get; set; }
        public double Price { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Distance { get; set; }
    }
}
