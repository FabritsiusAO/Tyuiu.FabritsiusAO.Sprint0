using Tyuiu.FabritsiusAO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FabritsiusAO.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Андрей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Андрей", res);
        }
        
            
        
    }
}