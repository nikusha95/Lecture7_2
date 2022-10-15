// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Enums;
using Enums.EnumMembers;

CarType type = CarType.Crossover;

Car c1 = new Car("BMW", "X1", CarType.Jeep, 250);
c1.PrintCarInfo();

Console.WriteLine();

Car c2 = new Car("Mercedes", "CLS", CarType.Suv);
c2.PrintCarInfo();
Console.WriteLine();

Console.WriteLine((int)type);

Console.WriteLine(type);
var carType = Enum.Parse<CarType>("suv",true);

Console.WriteLine(carType);

