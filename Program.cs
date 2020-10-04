using a01.Shared.Functions;
using a01.Shared.Objects;
using System;
using System.Linq;

namespace c01
{
    class Program
    {
        static void Main(string[] args)
        {
            Climate climate = new Climate(-25, 20, 2);
            Floors floors = new Floors(1,10);
            floors.AddSingle(1, 4.5);
            floors.AddRange((2,10), 3.15);
            Console.WriteLine($"Floors.Qu : {floors.Qu}");
            Console.WriteLine($"NotSpecified : {floors.NotSpecified}");
            Console.WriteLine($"Levels.Count : {floors.Levels.Count}");
            foreach (var item in floors.Levels)
            {
                Console.WriteLine($"floor : {item.Key} level : {Math.Round(item.Value.level,3)}");
            }
            floors.Qu = 9;
            Console.WriteLine("After floors.Qu=9----------->");
            Console.WriteLine($"Floors.Qu : {floors.Qu}");
            Console.WriteLine($"Levels.Count : {floors.Levels.Count}");
            Console.WriteLine($"NotSpecified : {floors.NotSpecified}");
            floors.AddRange((1, 9), 3.15);
            Console.WriteLine($"After floors.AddRange----------->");
            Console.WriteLine($"Levels.Count : {floors.Levels.Count}");
            Console.WriteLine($"NotSpecified : {floors.NotSpecified}");
            foreach (var item in floors.Levels)
            {
                Console.WriteLine($"floor : {item.Key} level : {Math.Round(item.Value.level, 3)}");
            }
            floors.Qu = 6;
            Console.WriteLine("After floors.Qu=6------>");
            Console.WriteLine($"Floors.Qu : {floors.Qu}");
            Console.WriteLine($"Levels.Count : {floors.Levels.Count}");
            Console.WriteLine($"NotSpecified : {floors.NotSpecified}");
            Console.WriteLine($"First floor : {floors.First}");
            floors.AddRange((1, 6), 3.2);
            foreach (var item in floors.Levels)
            {
                Console.WriteLine($"floor : {item.Key} level : {Math.Round(item.Value.level, 3)}");
            }
            floors.First = 2;
            Console.WriteLine("After floors.First=2------>");
            Console.WriteLine($"Floors.Qu : {floors.Qu}");
            Console.WriteLine($"Levels.Count : {floors.Levels.Count}");
            Console.WriteLine($"NotSpecified : {floors.NotSpecified}");
            Console.WriteLine($"First floor : {floors.First}");
            floors.AddRange((2, 6), 3.2);
            floors.AddSingle(7, 4);
            foreach (var item in floors.Levels)
            {
                Console.WriteLine($"floor : {item.Key} level : {Math.Round(item.Value.level, 3)}");
            }

            //DoorOutside doorO = new DoorOutside(1.36,2.4);
            //DoorInside doorI = new DoorInside(1.1, 2.1,196000);
            //StairCase stair = new StairCase(16, StairCase.Portal.Straight, floors, doorO,1, doorI);
            //MethodsSupplyStair meth = new MethodsSupplyStair(stair, climate);
            //meth.CompCollect();
            //Console.WriteLine($"Pwind : {meth.Pwind}");
            //Console.WriteLine($"Ps2 : {meth.Ps2_23}");
            //Console.WriteLine($"Gsa : {meth.Gsa_24}");
            //Console.WriteLine($"Door smoke resistance : {doorI.SmokeResistance}");
            //Console.WriteLine($"---------------------------------");
            //var results=meth.EachFloorResults.OrderByDescending(x => x.LevelKey);
            //foreach (var item in results)
            //{
            //    var lk = String.Format("{0:0.##}", item.LevelKey);
            //    var v = String.Format("{0:0.##}", item.V);
            //    var p = String.Format("{0:0.##}", item.P);
            //    var gsd = String.Format("{0:0.##}", item.Gsd);
            //    var gsw = String.Format("{0:0.##}", item.Gsw);
            //    var gsum = String.Format("{0:0.##}", item.Gsum);

            //    Console.WriteLine($"{lk}  |  {item.LevelValue}  |  {v}  |  {p}  |  {gsd}  |  {gsw}  |  {gsum}");
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine($"Fan capacity : {Math.Round(meth.Lv)}");

        }
    }
}
