using a01.Shared.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Window
    {

        public Window(double width, double height, Climate climate, Pressures pressures)
        {
            Area = width*height;
            Width = width;
            Height = height;
            Climate = climate;
            Pressures = pressures;
            AirResistanceRn = (1 / BreathabilityGn) * Math.Pow(Pressures.OutsideDeltaPMax / 10, (double)2/3);
        }
        public double Area { get; }
        public double BreathabilityGn { get; set; } = 6;
        public double Width { get; set; }
        public double Height { get; set; }
        public Climate Climate { get; }
        public Pressures Pressures { get; }
        public double Leakage { get; private set; }
        public double AirResistanceRn { get; private set; }

        public void CompLeakage(
                double pressureCurrentFloorStaircase,
                double floorLevelCurrent
            )
        {
            

            double g = 9.81;
            Leakage = (Area / (AirResistanceRn * 3600)) * Math.Pow(((pressureCurrentFloorStaircase + g * (floorLevelCurrent + 0.5 * (2.1)) * (Climate.DensitySupply - Climate.DensityInside))), 0.67);
        }
    }

}
