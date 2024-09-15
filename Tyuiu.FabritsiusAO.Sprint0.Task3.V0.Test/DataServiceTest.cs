using Tyuiu.FabritsiusAO.Sprint0.Task3.V0.Lib;
namespace Tyuiu.FabritsiusAO.Sprint0.Task3.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}