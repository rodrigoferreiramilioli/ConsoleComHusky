using Xunit;

namespace TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var teste = true; // se mudar essa linha para false, os testes vão quebrar e o dev não conseguirar mais dar push, devido ao husky validar os testes
            Assert.True(teste);
        }
    }
}
