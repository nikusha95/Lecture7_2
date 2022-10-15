// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Reflection;
using System.Threading.Channels;
using Structs;

PointClass p1 = new PointClass(0, 0);
//p1 -----> 0,0
var distance1 = p1.Distance(3, 4);
PointClass p2 = p1;

Console.WriteLine($"p1.x {p1.x} p1.y {p1.y}");
Console.WriteLine($"p2.x {p2.x} p2.y {p2.y}");
p1.x = 10;
Console.WriteLine();
Console.WriteLine($"p1.x {p1.x} p1.y {p1.y}");
Console.WriteLine($"p2.x {p2.x} p2.y {p2.y}");
//Console.WriteLine(distance1);
Console.WriteLine();

PointStruct p3 = new PointStruct(1, 1);
var distance3 = p3.Distance(3, 7);
PointStruct p4 = p3;
Console.WriteLine($"p3.x {p3.x} p3.y {p3.y}");
Console.WriteLine($"p4.x {p4.x} p4.y {p4.y}");
//Console.WriteLine(distance3);
p4.x = 12;
Console.WriteLine($"p3.x {p3.x} p3.y {p3.y}");
Console.WriteLine($"p4.x {p4.x} p4.y {p4.y}");
//p3
//1,1