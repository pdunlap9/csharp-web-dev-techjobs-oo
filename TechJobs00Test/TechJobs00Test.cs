using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobs00Test
{
    [TestClass]
    public class TechJobs00Test
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job catSitter = new Job();
            Job dogWalker = new Job();
            int a = catSitter.Id;
            int b = dogWalker.Id;
            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer ACME = new Employer();
            Location Desert = new Location();
            PositionType QualityControl = new PositionType();
            CoreCompetency Persistence = new CoreCompetency();
            Job ProductTester = new Job("Product tester", ACME, Desert, QualityControl, Persistence);

            Assert.AreEqual(ProductTester.Name, "Product tester");
            Assert.AreEqual(ProductTester.EmployerLocation, Desert);
            Assert.AreEqual(ProductTester.JobType, QualityControl);
            Assert.AreEqual(ProductTester.JobCoreCompetency, Persistence);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer neighbor = new Employer();
            Location nextDoor = new Location();
            PositionType watching = new PositionType();
            CoreCompetency loving = new CoreCompetency();
            Job blackCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);
            Job whiteCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);

            Assert.IsFalse(blackCatSitter.Equals(whiteCatSitter));

        }

    }
}
