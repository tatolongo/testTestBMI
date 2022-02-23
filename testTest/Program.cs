using System;

namespace testTest
{
    class MainClass
    {
        public static iBmi TrybBMI(iBmi trybMBI)
        {
            return trybMBI;
        }

        public static void Main(string[] args)
        {
            iBmi KalkulatorBMI = TrybBMI(new BMIAdult());
            KalkulatorBMI.setWagaKg(77);
            KalkulatorBMI.setWzrostCm(180);
            Console.WriteLine("BMI = " + KalkulatorBMI.CaclulateBMI().ToString());

        }
    }
}
