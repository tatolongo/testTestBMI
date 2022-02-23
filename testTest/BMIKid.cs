using System;
namespace testTest
{
    public class BMIKid : iBmi
    {
        private double Wzrost { get; set; }
        private double Waga { get; set; }
        private int Mnoznik { get; set; }

        public BMIKid()
        {
            this.Wzrost = 0;
            this.Waga = 0;
            this.Mnoznik = 703;
        }

        public double CaclulateBMI()
        {
            return Wzrost > 0 ? Waga / ((Wzrost / 100) * (Wzrost / 100)) * Mnoznik : 0;
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
