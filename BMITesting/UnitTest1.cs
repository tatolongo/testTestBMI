using System;
using Xunit;

namespace BMITesting
{
    public class BMITesting
    {
        private readonly testTest.BMIAdult ob = new testTest.BMIAdult();

        [Fact]
        public void AdultBMI_CacluclateBMIMethod_TestHeightZeroNoException()
        {
            //arrange
            ob.setWzrostCm(0);
            ob.setWagaKg(0);

            //act
            var exception = Record.Exception(() => ob.CaclulateBMI());


            //assert
            Assert.IsNotType<DivideByZeroException>(exception);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void AdultBMI_CaclulateBMIMethod_CheckIfZero(double value)
        {
            //arrange
            ob.setWzrostCm(value);

            //act
            double result = ob.CaclulateBMI();

            //assert
            Assert.Equal(0, result);
        }
    }
}
