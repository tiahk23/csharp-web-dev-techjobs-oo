using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.IsFalse(test_job2.Id - 1 != test_job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Employer test_employerName = new Employer("ACME");
            Location test_location = new Location("Desert");
            PositionType test_position_type = new PositionType("Quality Control");
            CoreCompetency test_core_competency = new CoreCompetency("Persistence");

            Job test_job3 = new Job("Product tester", test_employerName, test_location, test_position_type, test_core_competency);
            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual(test_employerName, test_job3.EmployerName);
            Assert.AreEqual(test_location, test_job3.EmployerLocation);
            Assert.AreEqual(test_position_type, test_job3.JobType);
            Assert.AreEqual(test_core_competency, test_job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job_idTest1 = new Job();
            Job job_idTest2 = new Job();
            Assert.IsFalse(job_idTest1.Equals(job_idTest2));

        }

        [TestMethod]
        public void TestJobsForToStingThatStartsAndEndsWithABlankLine()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string newString = job4.ToString();
            Assert.IsTrue(newString.StartsWith("\n"));
            Assert.IsTrue(newString.EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobsForEachNewLabelAndToBeOnItsOwnNewLine()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = "\nID: " + job4.Id + "\nName: " + job4.Name + "\nEmployer: " + job4.EmployerName + "\nLocation: " + job4.EmployerLocation + "\nPosition Type: " + job4.JobType + "\nCore Competency: " + job4.JobCoreCompetency + "\n";
            string newString = job4.ToString();
            Assert.AreEqual(testString, newString);
        }

        [TestMethod]
        public void TestOutputOfEmptyField()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4.EmployerName.Value = "";
            job4.EmployerLocation.Value = "";
            job4.JobType.Value = "";
            job4.JobCoreCompetency.Value = "";
            string newString = job4.ToString();
            Assert.IsTrue(newString.Contains("Data not avalible"));
        }
        
    }
}
