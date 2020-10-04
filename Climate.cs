using SharpFluids;
using UnitsNet;

namespace a01.Shared.Functions{
    public class Climate
    {
        public Climate(double tempOutside,double tempInside,double windVelocity)
        {
            TempOutside = tempOutside;
            TempInside = tempInside;
            WindVelocity = windVelocity;
        }
        private double tempSupply;
        private double densityOutside;
        private double densityInside;
        private double densitySupply;

        public double TempOutside { get; set; }
        public double TempInside { get; set; }
        public double TempSupply
        {
            get
            {
                tempSupply = (TempOutside + TempInside) / 2;
                return tempSupply;
            }
        }
        public double WindVelocity { get; set; }
        public double DensityOutside
        {
            get
            {
                Fluid air = new Fluid(FluidList.Air);
                air.UpdatePT(Pressure.FromBars(1.013), Temperature.FromDegreesCelsius(TempOutside));
                densityOutside = air.Density.Value;
                return densityOutside;
            }
        }
        public double DensityInside
        {
            get
            {
                Fluid air = new Fluid(FluidList.Air);
                air.UpdatePT(Pressure.FromBars(1.013), Temperature.FromDegreesCelsius(TempInside));
                densityInside = air.Density.Value;
                return densityInside;
                
            }
        }
        public double DensitySupply
        {
            get
            {
                Fluid air = new Fluid(FluidList.Air);
                air.UpdatePT(Pressure.FromBars(1.013), Temperature.FromDegreesCelsius(TempSupply));
                densitySupply = air.Density.Value;
                return densitySupply;
            }
        }
    }
}