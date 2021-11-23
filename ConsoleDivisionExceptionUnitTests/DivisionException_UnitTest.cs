using ConsoleDivisionExceptionApp;
using System;
using Xunit;

namespace ConsoleDivisionExceptionUnitTests
{
    public class DivisionException_UnitTest
    {
        [Fact]
        public void DividirInteiros_DenominadorZero_LançarMinhaExceçao()
        {

            //arrange
            var x = 10;
            var y = 0;
            var sut = new ExceptionTest();

            //act //assert
            var ex = Assert.Throws<MyClassException>(() => sut.Dividir(x, y));

            Assert.IsAssignableFrom<Exception>(ex.GetBaseException());
            Assert.Contains("customizada", ex.Message);
            
        }

        [Fact]
        public void DividirInteiros_ValoresPositivos_RetornarDouble()
        {
            //arrange
            var x = 10;
            var y = 3;
            var sut = new ExceptionTest();

            //act
            var result = sut.Dividir(x, y);

            //assert
            Assert.IsType<double>(result);
        }
    }
}