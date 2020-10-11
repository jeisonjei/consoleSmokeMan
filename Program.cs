using a01.Shared.Functions;
using a01.Shared.Objects;
using Main;
using System;
using System.Linq;

namespace c01
{
    class Program
    {
        static void Main(string[] args)
        {
            Climate climate = new Climate(-25, 20, 2);
            Floors floors = new Floors(1,16,1);
            
            floors.AddSingle(1, 5);
            floors.AddRange((2,16), 3);
            Pressures pressures = new Pressures(floors, climate);
            Console.WriteLine($"ROOF LEVEL : {floors.RoofFloorLevel}");
            Console.WriteLine($"PRESSURE OUTSIDE MAX : {pressures.OutsideDeltaPMax}");
            Window window = new Window(1.8, 1, climate, pressures);
            Console.WriteLine($"WINDOW AREA : {window.Area}");
            DoorOutside doorO = new DoorOutside(1.36, 2.4);
            DoorInside doorI = new DoorInside(1.1, 2.1, 196000);
            StairCase stair = new StairCase(16, StairCase.Portal.Straight, floors, doorO, 1, doorI,window);

            MethodsSupplyStair meth = new MethodsSupplyStair(stair, climate);
            meth.CompCollect();
            Console.WriteLine($"Pwind : {meth.Pwind}");
            Console.WriteLine($"Ps2 : {meth.Ps2_23}");
            Console.WriteLine($"Gsa : {meth.Gsa_24}");
            Console.WriteLine($"Door smoke resistance : {doorI.SmokeResistance}");
            Console.WriteLine($"---------------------------------");
            var results = meth.EachFloorResults.OrderByDescending(x => x.LevelKey);
            foreach (var item in results)
            {
                var lk = String.Format("{0:0.##}", item.LevelKey);
                var v = String.Format("{0:0.##}", item.V);
                var p = String.Format("{0:0.##}", item.P);
                var gsd = String.Format("{0:0.##}", item.Gsd);
                var gsw = String.Format("{0:0.##}", item.Gsw);
                var gsum = String.Format("{0:0.##}", item.Gsum);

                Console.WriteLine($"{lk}  |  {item.LevelValue}  |  {v}  |  {p}  |  {gsd}  |  {gsw}  |  {gsum}");
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"Fan capacity : {Math.Round(meth.Lv)}");

        }
    }
}
