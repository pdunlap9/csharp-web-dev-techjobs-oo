using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
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
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType QualityControl = new PositionType("QualityControl");
            CoreCompetency Persistence = new CoreCompetency("Persistence");
            Job ProductTester = new Job("Product tester", ACME, Desert, QualityControl, Persistence);

            Assert.AreEqual(ProductTester.Name, "Product tester");
            Assert.AreEqual(ProductTester.EmployerLocation, Desert);
            Assert.AreEqual(ProductTester.JobType, QualityControl);
            Assert.AreEqual(ProductTester.JobCoreCompetency, Persistence);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer neighbor = new Employer("neighbor");
            Location nextDoor = new Location("nextDoor");
            PositionType watching = new PositionType("watching");
            CoreCompetency loving = new CoreCompetency("loving");
            Job blackCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);
            Job whiteCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);

            Assert.IsFalse(blackCatSitter.Equals(whiteCatSitter));

        }


        [TestMethod]
        public void TestBlankLinesBeforeAndAfter()
        {
            Employer bob = new Employer("bob");
            Location house = new Location("house");
            PositionType maid = new PositionType("maid");
            CoreCompetency fast = new CoreCompetency("fast");
            Job cleaner = new Job("Frank", bob, house, maid, fast);

            string expectedOutput = $"\n ID: {cleaner.Id} \n Name: {cleaner.Name} \n Employer: {cleaner.EmployerName} \n Location: {cleaner.EmployerLocation} \n Position Type: {cleaner.JobType} \n Core Competency: {cleaner.JobCoreCompetency} \n";

            Assert.AreEqual(expectedOutput, cleaner.ToString());

        }

        [TestMethod]
        public void TestToString()
        {

            Employer neighbor = new Employer("neighbor");
            Location nextDoor = new Location("nextDoor");
            PositionType watching = new PositionType("watcher");
            CoreCompetency loving = new CoreCompetency("loving");
            Job redCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);
            string expectedOutput = $"\n ID: {redCatSitter.Id} \n Name: Kitty \n Employer: neighbor \n Location: nextDoor \n Position Type: watcher \n Core Competency: loving \n";
            Assert.AreEqual(expectedOutput, redCatSitter.ToString()

                 );
        }


        [TestMethod]
        public void AllBlank()
        {

            Employer neighbor = new Employer("");
            Location nextDoor = new Location("nextDoor");
            PositionType watching = new PositionType("watcher");
            CoreCompetency loving = new CoreCompetency("loving");
            Job redCatSitter = new Job("Kitty", neighbor, nextDoor, watching, loving);
            string expectedOutput = $"\n ID: {redCatSitter.Id} \n Name: Kitty \n Employer:  \n Location: nextDoor \n Position Type: watcher \n Core Competency: loving \n";
            Assert.AreEqual(expectedOutput, redCatSitter.ToString()

                 );
        }
    }
}