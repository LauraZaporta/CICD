using CICDLibrary;

namespace CICDTesting
{
    [TestClass]
    public class CICDTesting
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            int numA = 3;
            int numB = 5;
            int result;
            int resultShouldBe = numA + numB;
            //Act
            result = Calculator.Add(numA, numB);
            //Assert
            Assert.AreEqual(resultShouldBe, result);
        }
    }
}