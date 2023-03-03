using Challenge12.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Challenge12.DataAccess
{
    public class EmployeeDal: BaseRepository<Employee>
    {
        public List<EmployeeDto> GetAllFullName()
        {
            using (var context = new NorthwindContext())
            {
                try
                {
                    var query = (from emp in context.Employees.ToList()
                                select new EmployeeDto
                                {
                                    EmployeeID = emp.EmployeeID,
                                    FullName = emp.FirstName + " " + emp.LastName,
                                });
                    return query.ToList();
                }
                catch (System.Exception)
                {

                    throw;
                }
                
            }
        }
    }
}
