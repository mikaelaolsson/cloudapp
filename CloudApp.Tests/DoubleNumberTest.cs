using System;
using Xunit;
using CloudApp.Tools;

namespace CloudApp.Tests {
    public class DoubleNumberTest {
        [Fact]
        public void DoubleTheNumber() {
            var doubleNumber = new DoubleNumber();

            var number = 20;

            var result = doubleNumber.Calc(number);

            Assert.Equal(40, result);
        }
    }
}
