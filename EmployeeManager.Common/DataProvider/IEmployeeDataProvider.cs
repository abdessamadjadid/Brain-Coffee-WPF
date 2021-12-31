using EmployeeManager.Common.Model;
using System.Collections.Generic;

namespace EmployeeManager.Common.DataProvider
{
  public interface IEmployeeDataProvider
  {
    IEnumerable<Employee> LoadEmployees();

    void SaveEmployee(Employee employee);

    IEnumerable<JobRole> LoadJobRoles();
  }
}
