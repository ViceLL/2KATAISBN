using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grabacion2TareaSemana4Tendencias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod10DigitosValido()
        {
            bool validation_result = false;
            int[] ISBN10 = { 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };
            int suma10 = 0;

            for (int i = 9; i >= 0; i--)
            {
                if (ISBN10[i] < 0 || ISBN10[i] > 9)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    suma10 += ISBN10[i] * (i + 1);
                }
            }
            validation_result = (suma10 % 11 == 0);

            Assert.IsTrue(validation_result);

        }

        [TestMethod]
        public void TestMethod10DigitosInvalido()
        {
            bool validation_result = false;
            int[] ISBN10 = {1,2,3,4,5,6,7,8,9,0};
            int suma10 = 0;

            for (int i = 9; i >= 0; i--)
            {
                if (ISBN10[i] < 0 || ISBN10[i] > 9)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    suma10 += ISBN10[i] * (i + 1);
                }
            }
            validation_result = (suma10 % 11 == 0);

            Assert.IsFalse(validation_result);

        }

        [TestMethod]
        public void TestMethod13DigitosValido()
        {
            bool validation_result = false;
            int[] ISBN13 = { 9, 7, 8, 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };
            int suma13a = 0, suma13b = 0, suma13t = 0;

            for (int i = 12; i >= 0; i--)
            {
                if (ISBN13[i] < 0 || ISBN13[i] > 9)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    if ((i + 1) % 2 == 0)
                    {
                        suma13a += ISBN13[i] * 3;
                    }
                    else
                    {
                        suma13b += ISBN13[i] * 1;
                    }
                }
            }
            suma13t = suma13a + suma13b;

            validation_result = (suma13t % 10 == 0);
            Assert.IsTrue(validation_result);

        }

        [TestMethod]
        public void TestMethod13DigitosInvalido()
        {
            bool validation_result = false;
            int[] ISBN13 = {1,2,3,4,5,6,7,8,9,0,1,2,3};
            int suma13a = 0, suma13b = 0, suma13t = 0;

            for (int i = 12; i >= 0; i--)
            {
                if (ISBN13[i] < 0 || ISBN13[i] > 9)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    if ((i + 1) % 2 == 0)
                    {
                        suma13a += ISBN13[i] * 3;
                    }
                    else
                    {
                        suma13b += ISBN13[i] * 1;
                    }
                }
            }
            suma13t = suma13a + suma13b;

            validation_result = (suma13t % 10 == 0);
            Assert.IsFalse(validation_result);

        }
    }
}