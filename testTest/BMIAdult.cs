using System;
namespace testTest
{
    public class BMIAdult : iBmi
    {
        private double Wzrost { get; set; }
        private double Waga { get; set; }

        public BMIAdult()
        {
            this.Wzrost = 0;
            this.Waga = 0;
        }

        public double CaclulateBMI()
        {
            return  Wzrost > 0 ? Waga / ((Wzrost/100) * (Wzrost/100)) : 0;
        }

        public void setWagaKg(double waga)
        {
            this.Waga = waga;
        }

        public void setWzrostCm(double wzrost)
        {
            this.Wzrost = wzrost;
        }
    }
}
