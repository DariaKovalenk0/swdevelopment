using System;
using Xunit;
using NSubstitute;

namespace TestProject1
{
    public class UnitTest1
    {
        private ILogger loggerStub = Substitute.For<ILogger>();


        [Fact]
        public void TestForDerTg()
        {
            var loggerMock = Substitute.For<ILogger>();
            var calculator = new Calculator(loggerStub);
            var result = calculator.Der_tg(0);
            var expected = 1;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestForDerLn()
        {
            var calculator = new Calculator(loggerStub);
            var result = calculator.Der_ln(0.5);
            var expected = 2;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestForDerExp()
        {
            var calculator = new Calculator(loggerStub);
            var result = calculator.Der_exp(0);
            var expected = 1;
            Assert.Equal(expected, result);
        }
    }
}
 
