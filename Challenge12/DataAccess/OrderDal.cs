using Challenge12.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Challenge12.DataAccess
{
    public class OrderDal : BaseRepository<Order>
    {
        EmployeeDal employeeDal = new EmployeeDal();
        public List<OrderDto> GetAllDto()
        {
            using (var context = new NorthwindContext())
            {
                try
                {
                    var query = (from order in context.Orders.ToList()
                                 join customer in context.Customers on order.CustomerID equals customer.CustomerID
                                 join employee in employeeDal.GetAll() on order.EmployeeID equals employee.EmployeeID

                                 where context.Orders.Count() > 0

                                 select new OrderDto
                                 {
                                     OrderID = order.OrderID,
                                     CompanyNameofCustomer = customer.CompanyName,
                                     EmployeeName = string.Concat(employee.FirstName+" "+employee.LastName),
                                     OrderDate = order.OrderDate,
                                     RequiredDate = order.RequiredDate,
                                     ShippedDate = order.ShippedDate,
                                     ShipVia = order.ShipVia,
                                     Freight = order.Freight,
                                     ShipName = order.ShipName,
                                     ShipAddress = order.ShipAddress,
                                     ShipCity = order.ShipCity,
                                     ShipRegion = order.ShipRegion,
                                     ShipPostalCode = order.ShipPostalCode,
                                     ShipCountry = order.ShipCountry
                                 }).ToList();
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
