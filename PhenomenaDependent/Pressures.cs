using a01.Shared.Functions;
using a01.Shared.Objects;
using System;

namespace Main
{
    public class Pressures
    {
        private double outsideDeltaPMax;

        public Pressures(Floors floors,Climate climate)
        {
            Floors = floors;
            Climate = climate;
        }

        public StairCase Stair { private get; set; }
        public Floors Floors { private get; set; }
        public Climate Climate { private get; set; }

        public double OutsideDeltaPMax
        {
            get => 0.55 * Floors.HeightFromFirstToTopOfTheShaft * (Climate.SpecificGravityOutside - Climate.SpecificGravityInside) + 0.03 * (Climate.SpecificGravityOutside) * Math.Pow(2, 2);
            set
            {
                outsideDeltaPMax = value;

            }
        }
    }
}