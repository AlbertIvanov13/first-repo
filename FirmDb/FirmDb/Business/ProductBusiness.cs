using FirmDb.Data;
using FirmDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmDb.Business
{
    public class ProductBusiness
    {
        private ProductContext productContext;

        public List<Employee> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Employees.Find(id);
            }
        }

        public void Add(Employee employee)
        {
            using (productContext = new ProductContext())
            {
                productContext.Employees.Add(employee);
                productContext.SaveChanges();
            }
        }

        public void Update(Employee employee)
        {
            using (productContext = new ProductContext())
            {
                var item = productContext.Employees.Find(employee.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(employee);
                    productContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var product = productContext.Employees.Find(id);
                if (product != null)
                {
                    productContext.Employees.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }
    }
}
