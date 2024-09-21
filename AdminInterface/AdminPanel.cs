using LogisticService.Models;
using LogisticService.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.AdminInterface
{
    public class AdminPanel
    {
        Repository<CarType, int, DbContext> CarTypeRepository { get; set; }
        Repository<Container, int, DbContext> ContainerRepository { get; set; }
        Repository<CrushedCar, int, DbContext> CrushedCarRepository { get; set; }
        Repository<Direction, int, DbContext> DirectionRepository { get; set; }
        public void AdminChoiceTable()
        {
            Console.WriteLine("Choose Table");
            Console.WriteLine("1.Car Type\n2.Container\n3.Crushed Car\n4.Direction");

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    AdminChooseCarType();
                    break;
                case 2:
                    AdminChooseContainer();
                    break;
                case 3:
                    AdminChooseIsCarCrushed();
                    break;
                case 4:
                    AdminChooseDirection();
                    break;
                default:
                    break;
            }
        }


        public void AdminChooseCarType()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1.Add\n2.Update\n3.Get By Id\n4.Get all\n5.Delete");

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Add");
                    Console.WriteLine("Choose Car Type");
                    Console.WriteLine("Choose Car Id");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Car Name");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Write Coefficient");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    CarType carType1 = new CarType(id1, name1, d1);
                    CarTypeRepository.Add(carType1);
                    Console.WriteLine($"ID: {id1}\tName of car: {name1}\tCoefficient: {d1}");
                    break;
                case 2:
                    Console.WriteLine("Update");
                    Console.WriteLine("Choose Car Id");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Car Name");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Write Coefficient");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    CarType carType2 = new CarType(id2, name2, d2);
                    CarTypeRepository.Update(carType2);
                    Console.WriteLine($"ID: {id2}\tName of car: {name2}\tCoefficient: {d2}");
                    break;
                case 3:
                    Console.WriteLine("Get By Id");
                    Console.WriteLine("Choose Car Id");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    CarTypeRepository.FindByKey(id3);
                    break;
                case 4:
                    Console.WriteLine("Get All");
                    CarTypeRepository.GetAll();
                    break;
                case 5:
                    Console.WriteLine("Delete");
                    Console.WriteLine("Choose Car Id");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    CarTypeRepository.Delete(id5);
                    break;
                default:
                    break;
            }
        }

        public void AdminChooseContainer()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1.Add\n2.Update\n3.Get By Id\n4.Get all\n5.Delete");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Add");
                    Console.WriteLine("Choose Container Id");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Container Type(Open or Closed)");
                    bool name1 = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Write Coefficient");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Container container1 = new Container(id1, name1, d1);
                    ContainerRepository.Add(container1);
                    Console.WriteLine($"ID: {id1}\tName of container: {name1}\tCoefficient: {d1}");
                    break;
                case 2:
                    Console.WriteLine("Update");
                    Console.WriteLine("Choose Container Id");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Container Type(Open or Closed)");
                    bool name2 = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Write Coefficient");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    Container container2 = new Container(id2, name2, d2);
                    ContainerRepository.Update(container2);
                    Console.WriteLine($"ID: {id2}\tName of container: {name2}\tCoefficient: {d2}");
                    break;
                case 3:
                    Console.WriteLine("Get By Id");
                    Console.WriteLine("Choose Container Id");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    ContainerRepository.FindByKey(id3);
                    break;
                case 4:
                    Console.WriteLine("Get All");
                    ContainerRepository.GetAll();
                    break;
                case 5:
                    Console.WriteLine("Delete");
                    Console.WriteLine("Choose Container Id");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    ContainerRepository.Delete(id5);
                    break;
                default:
                    break;
            }
        }

        public void AdminChooseIsCarCrushed()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1.Add\n2.Update\n3.Get By Id\n4.Get all\n5.Delete");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Add");
                    Console.WriteLine("Choose Crushed Car Id");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Is Car Crushed");
                    bool name1 = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Write Coefficient");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    CrushedCar crushedCar1 = new CrushedCar(id1, name1, d1);
                    CrushedCarRepository.Add(crushedCar1);
                    Console.WriteLine($"ID: {id1}\tIs Car Crushed: {name1}\tCoefficient: {d1}");
                    break;
                case 2:
                    Console.WriteLine("Update");
                    Console.WriteLine("Choose Crushed Car Id");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Is Car Crushed");
                    bool name2 = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Write Coefficient");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    CrushedCar crushedCar2 = new CrushedCar(id2, name2, d2);
                    CrushedCarRepository.Update(crushedCar2);
                    Console.WriteLine($"ID: {id2}\tIs Car Crushed: {name2}\tCoefficient: {d2}");
                    break;
                case 3:
                    Console.WriteLine("Get By Id");
                    Console.WriteLine("Choose Crushed Car Id");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    CrushedCarRepository.FindByKey(id3);
                    break;
                case 4:
                    Console.WriteLine("Get All");
                    CrushedCarRepository.GetAll();
                    break;
                case 5:
                    Console.WriteLine("Delete");
                    Console.WriteLine("Choose Crushed Car Id");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    CrushedCarRepository.Delete(id5);
                    break;
                default:
                    break;
            }
        }

        public void AdminChooseDirection()
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1.Add\n2.Update\n3.Get By Id\n4.Get all\n5.Delete");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Add");
                    Console.WriteLine("Choose Direction Id");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Price");
                    double price1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose From");
                    string from1 = Console.ReadLine();
                    Console.WriteLine("Choose To");
                    string to1 = Console.ReadLine();
                    Console.WriteLine("Write Distance");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"ID: {id1}\tPrice: {price1}\tFrom: {from1}\tTo: {to1}\tDistance: {d1}");
                    Direction direction1 = new Direction(id1, price1, from1, to1, d1);
                    DirectionRepository.Add(direction1);
                    break;
                case 2:
                    Console.WriteLine("Update");
                    Console.WriteLine("Choose Direction Id");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose Price");
                    double price2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose From");
                    string from2 = Console.ReadLine();
                    Console.WriteLine("Choose To");
                    string to2 = Console.ReadLine();
                    Console.WriteLine("Write Distance");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"ID: {id2}\tPrice: {price2}\tFrom: {from2}\tTo: {to2}\tDistance: {d2}");
                    Direction direction2 = new Direction(id2, price2, from2, to2, d2);
                    DirectionRepository.Update(direction2);
                    break;
                case 3:
                    Console.WriteLine("Get By Id");
                    Console.WriteLine("Choose Direction Id");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    DirectionRepository.FindByKey(id3);
                    break;
                case 4:
                    Console.WriteLine("Get All");
                    DirectionRepository.GetAll();
                    break;
                case 5:
                    Console.WriteLine("Delete");
                    Console.WriteLine("Choose Direction Id");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    DirectionRepository.Delete(id5);
                    break;
                default:
                    break;
            }
        }
    }
}
