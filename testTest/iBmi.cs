using System;
namespace testTest
{
    public interface iBmi
    {
        public void setWagaKg(double waga);
        public void setWzrostCm(double wzrost);
        public double CaclulateBMI();
    }
}
