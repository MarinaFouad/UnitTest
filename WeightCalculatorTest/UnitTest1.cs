using WeightCalculator;

namespace WeightCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetIdealWeight_Height_176_gender_w_64()
        {
            weightEquation sut = new weightEquation
            {
                Height = 176,
                Gender = 'w'
            };
            int actual = sut.WeightUsingEquation(); 
            int expected = 64;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetIdealWeight_Height_170_gender_m_65()
        {
            weightEquation sut = new weightEquation
            {
                Height = 170,
                Gender = 'm'
            };
            int actual = sut.WeightUsingEquation();
            int expected = 65;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetIdealWeight_Defualt()
        {
            weightEquation sut = new weightEquation
            {
                Height = 170,
                Gender = 'n'
            };
            int actual = sut.WeightUsingEquation();
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        [Priority(1)]
        //[ignore]

        public void trial()
        {
            // Assert.AreNotEqual(100, 50);
           // weightEquation w1 = new weightEquation();
           //// Assert.IsInstanceOfType(w1, typeof(weightEquation));
           // w1 = null; 
           // Assert.IsNull(w1);

            //for string 
            string name = "thisIsString";
            StringAssert.Contains(name,"this");

        }

    }
}