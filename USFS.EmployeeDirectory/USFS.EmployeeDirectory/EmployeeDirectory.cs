using System;
using System.DirectoryServices;

namespace USFS.EmployeeDirectory
{
    public class EmployeeDirectory: IEmployeeDirectory
    {

        private readonly DirectorySearcher directorySearcher;

        public EmployeeDirectory() : this(new DirectorySearcher())
        {
        }

        public EmployeeDirectory(DirectorySearcher ds)
        {
            directorySearcher = ds;
        }

        //Inside class
        public bool EmployeeExists(string employeeLanId)
        {
            if (String.IsNullOrEmpty(employeeLanId))
            {
                return false;
            }

            // specify the search filter
            directorySearcher.Filter = "(&(objectClass=user)(anr=" + employeeLanId + "))";

            // specify which property values to return in the search

            directorySearcher.PropertiesToLoad.Add("givenName");   // first name
            directorySearcher.PropertiesToLoad.Add("sn");          // last name
            directorySearcher.PropertiesToLoad.Add("mail");        // smtp mail address


            // perform the search
            SearchResultCollection result = directorySearcher.FindAll();
            return result.Count > 0;
        }

        public SearchResultCollection GetEmployeeInformation(string employeeLanId, System.Collections.Generic.ICollection<string> activeDirectoryProperties)
        {
            if (String.IsNullOrEmpty(employeeLanId))
            {
                throw new ArgumentNullException(employeeLanId,"You can't have a null employee you fool!" );
            }

            // specify the search filter
            directorySearcher.Filter = "(&(objectClass=user)(anr=" + employeeLanId + "))";

            foreach (string propertyname in activeDirectoryProperties)
            {
                directorySearcher.PropertiesToLoad.Add(propertyname);
            }

            return (directorySearcher.FindAll());

        }

        public SearchResultCollection GetAllEmployeesInDepartment(string department)
        {
            // specify the search filter
            directorySearcher.Filter = "(&(objectCategory=person)(objectClass=user)(department=" + department + "))";
            // specify which property values to return in the search
            directorySearcher.PropertiesToLoad.Add("givenName");   // first name
            directorySearcher.PropertiesToLoad.Add("sn");          // last name
            directorySearcher.PropertiesToLoad.Add("mail");        // smtp mail address

            // perform the search
            SearchResultCollection result = directorySearcher.FindAll();

            return result;
        }
    }
}