using System.Collections.Generic;
using System.DirectoryServices;

namespace USFS.EmployeeDirectory
{
    public interface IEmployeeDirectory
    {
        bool EmployeeExists(string employeeLanId);
        SearchResultCollection GetEmployeeInformation(string employeeLanId, ICollection<string> activeDirectoryProperties);
        SearchResultCollection GetAllEmployeesInDepartment(string department);
    }
}
