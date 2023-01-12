using Xunit;

namespace TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var teste = true;
            Assert.True(teste);
        }
    }
}
