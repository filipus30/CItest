using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProgramSimpleLife;

namespace TestSimpleProgramSimpleLife
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int result1 = p.getSum();

            Assert.IsTrue(result1 == 5);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Program p = new Program();
            int result2 = p.getMultiplication();

            Assert.IsTrue(result2 == 6);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Program p = new Program();
            int result3 = p.getSubstraction();
            Assert.IsTrue(result3 == 1);

        }



    }
}
