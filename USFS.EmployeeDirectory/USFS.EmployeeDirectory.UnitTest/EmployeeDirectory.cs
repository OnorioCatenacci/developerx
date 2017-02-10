using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using USFS.EmployeeDirectory;
using Moq;
using System.DirectoryServices;

namespace USFS.EmployeeDirectory.UnitTest
{
    public class EmployeeDirectory
    {
        private readonly USFS.EmployeeDirectory.EmployeeDirectory directory;
        private readonly string badLanId;
        private readonly string goodLanId;
        private readonly string badDept;
        private readonly string goodDept;


        public EmployeeDirectory()
        {
            badLanId = "ocatenacca";
            goodLanId = "ocatenacci";
            badDept = "Dream Police";
            goodDept = "Specialty Training";
            directory = new USFS.EmployeeDirectory.EmployeeDirectory();
        }

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void EmployeeExistsForNonExistentEmployeeShouldReturnFalse()
        {
            Assert.IsFalse(directory.EmployeeExists(badLanId));
        }

        [Test]
        public void EmployeeExistsForExistingEmployeeShouldReturnTrue()
        {
            Assert.IsTrue(directory.EmployeeExists(goodLanId));
        }

        [Test]
        public void EmployeeExistsForEmptyOrNullStringShouldReturnFalse()
        {
            string emptyLanId = null;
            Assert.IsFalse(directory.EmployeeExists(emptyLanId));
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void GetEmployeeInformationForNullEmployeeShouldReturnEmptyCollection()
        {
           Assert.IsEmpty(directory.GetEmployeeInformation(null, new List<string>())); 
        }

        [Test]
        public void GetEmployeeInformationForNonExistentEmployeeShouldReturnEmptyCollection()
        {
            Assert.IsEmpty(directory.GetEmployeeInformation(badLanId,new List<string>()));
        }

        [Test]
        public void GetEmployeeInformationForExistentEmployeeShouldReturnCollectionOfOneItem()
        {
            var result = directory.GetEmployeeInformation(goodLanId, new List<string>());
//            Assert.IsNotEmpty(result); //By definition if the count is 1 then the list isn't empty. This 
            // would be a redundant test
            Assert.AreEqual(result.Count, 1);
        }

        [Test]
        public void GetEmployeeInformationForExistentEmployeeWithListOfPropertiesShouldReturnCollectionOfOneItem()
        {
            Assert.AreEqual(directory.GetEmployeeInformation(goodLanId, new List<string> { "givenName" }).Count, 1);
        }
        [Test]
        public void GetDepartmentForNonExistentDepartmentShouldReturnEmptyList()
        {
            Assert.IsEmpty(directory.GetAllEmployeesInDepartment(badDept));
        }

        [Test]
        public void GetDepartmentForExistingDepartmentShouldReturnNonEmptyList()
        {
            Assert.IsNotEmpty(directory.GetAllEmployeesInDepartment(goodDept));
        }
    }
}
