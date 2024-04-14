using FreestyleJenkins;

namespace NUnitTesting
{
    public class Tests
    {
        Percentage obj;
        [SetUp]
        public void Setup()
        {
            obj = new Percentage();
        }

        //[TestCase(76)]
        //[TestCase(67)]
        [TestCase(98)]
        [TestCase(93)]

        public void Test1(int percentage)
        {
            var res = obj.GetGradeByPercentage(percentage);
            Assert.AreEqual("A", res);
        }
    }
}