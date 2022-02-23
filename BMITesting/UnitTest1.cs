using System;
using Xunit;

namespace BMITesting
{
    public class BMITesting
    {
        [Fact]
        public void AdultBMI_CacluclateBMIMethod_TestHeightZeroNoException()
        {
            //arrange
            testTest.BMIAdult ob = new testTest.BMIAdult();
            ob.setWzrostCm(0);
            ob.setWagaKg(0);

            //act
            var exception = Record.Exception(() => ob.CaclulateBMI());


            //assert
            Assert.IsNotType<DivideByZeroException>(exception);
        }
    }
}
