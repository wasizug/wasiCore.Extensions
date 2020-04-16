using wasiCore.Extensions;
using Xunit;

namespace wasiCore.Tests.Extensions
{
    public class NumberExtensionsTests
    {
        [Theory]
        [InlineData("123", 123)]
        [InlineData("98987", 98987)]
        [InlineData("-98987", -98987)]
        [InlineData("0", 0)]
        [InlineData("2147483647", 2147483647)]
        [InlineData("-2147483648", -2147483648)]
        public void ConvertStringToNumberHappyCase(string input, int expectedResult)
        {
            int value = input.ToInt();
            Assert.Equal(expectedResult, value);
        }
        
        [Theory]
        [InlineData("adfa", 1, 1)]
        [InlineData("2147483648", 1, 1)]
        [InlineData("-2147483649", 1, 1)]
        public void ConvertStringToNumberDefaultValueHappyCase(string input, int defaultValue, int expectedResult)
        {
            int value = input.ToInt(defaultValue);
            Assert.Equal(expectedResult, value);
        }
        
        [Theory]
        [InlineData("adfa")]
        [InlineData("2147483648")]
        [InlineData("-2147483649")]
        public void ConvertStringToNumberNullableFallbackHappyCase(string input)
        {
            int? value = input.ToIntNullable();
            Assert.Null(value);
        }
        
        [Theory]
        [InlineData("123", 123)]
        [InlineData("98987", 98987)]
        [InlineData("-98987", -98987)]
        [InlineData("0", 0)]
        [InlineData("2147483647", 2147483647)]
        [InlineData("-2147483648", -2147483648)]
        public void ConvertStringToNumberNullableHappyCase(string input, int? expectedResult)
        {
            int? value = input.ToIntNullable();
            Assert.Equal(expectedResult, value);
        }
    }
}