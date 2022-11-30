using FourOperations;

namespace Test_BasicMaths
{
    public class UnitTest1
    {
        [Fact]
        public void Test_AdditionMethod()
        {
            BasicOperations bo = new BasicOperations();
            double sonuc = bo.Addition(10, 5);
            Assert.Equal(15, sonuc);
        }

        [Fact]
        public void Test_ExtractMethod()
        {
            BasicOperations bo = new BasicOperations();
            double sonuc = bo.Extract(30, 5);
            Assert.Equal(25, sonuc);
        }
        [Fact]
        public void Test_MultiplicationMethod()
        {
            BasicOperations bo = new BasicOperations();
            double sonuc = bo.Multiplication(5, 5);
            Assert.Equal(25, sonuc);
        }

        //test failed because of wrong expression
        [Fact]
        public void Test_DividingMethod()
        {
            BasicOperations bo = new BasicOperations();
            double sonuc = bo.Dividing(50, 5);
            Assert.Equal(10, sonuc);
        }

        [Fact]
        public void Test_IsPositiveMethod()
        {
            BasicOperations bo = new BasicOperations();
            bool sonuc = bo.IsPositive(1);
            Assert.True(sonuc);
        }

    }
}