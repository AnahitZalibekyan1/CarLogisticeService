using LogisticService.AdminInterface;
using LogisticService.Models;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LogisticService.UserPanel
{
    public class UserMenu 
    {
        public string carType;
        public bool container;
        public bool isCarCrushed;
        public string from;
        public string to;
        public void Menu()
        {
            Console.WriteLine("Choose Car Type");
            carType = Console.ReadLine();

            Console.WriteLine("Choose Container Type");
            container = Convert.ToBoolean(Console.ReadLine());
          
            Console.WriteLine("Choose Car Crushed or not");
            isCarCrushed = Convert.ToBoolean(Console.ReadLine());
           
            Console.WriteLine("Choose Direction");
            Console.WriteLine("Choose From and To");
            from = Console.ReadLine();
            to = Console.ReadLine();

        }
    }
}
