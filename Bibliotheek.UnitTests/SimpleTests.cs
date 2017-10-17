using Xunit;

namespace Bibliotheek.UnitTests
{
    public class SimpleTests
    {
        [Fact]
        public void RegularTest()
        {
            Assert.Equal(1, 1 + 1 - 1);
            Assert.StartsWith("jup", "jupiler");
            Assert.True("abc" == "a" + "b" + "c");
        }

        [Fact(DisplayName = "Another test")]
        public void RegularTestPartTwo()
        {
            Assert.DoesNotContain("x", "abc");
            Assert.DoesNotContain(1, new [] { 3, 4 });
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void OurFirstTheory(int value)
        {
            Assert.IsType(typeof(int), value);
            Assert.True(value < 5);
        }
    }
}
