using a01.Shared.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Window
    {
        private double width;
        private double height;
        private Pressures pressures;

        public Window(double width, double height, Climate climate, Pressures pressures)
        {
            Area = width * height;
            Width = width;
            Height = height;
            Climate = climate;
            Pressures = pressures;
            AirResistanceRn = (1 / BreathabilityGn) * Math.Pow(Pressures.OutsideDeltaPMax / 10, (double)2 / 3);
        }
        public double Area { get; set; }
        public double BreathabilityGn { get; set; } = 6;
        public double Width
        {
            get => width; set
            {
                width = value;
                Area = Width * Height;
            }
        }
        public double Height
        {
            get => height; set
            {
                height = value;
                Area = Width * Height;
            }
        }
        public Climate Climate { get; set; }
        public Pressures Pressures
        {
            get => pressures; set
            {
                pressures = value;
                AirResistanceRn = (1 / BreathabilityGn) * Math.Pow(Pressures.OutsideDeltaPMax / 10, (double)2 / 3);
            }
        }
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
