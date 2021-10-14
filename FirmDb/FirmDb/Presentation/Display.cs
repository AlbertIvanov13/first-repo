using FirmDb.Business;
using FirmDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmDb.Presentation
{
    public class Display
    {
        private int closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new employee");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Delete entry by ID");
            Console.WriteLine("5. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;                 
                    default:
                        break;

                }
            } while (operation != closeOperationId);
        }

        public Display()
        {
            Input();
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Employee employee = productBusiness.Get(id);
            if (employee != null)
            {
                Console.WriteLine("Enter FirstName: ");
                employee.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName: ");
                employee.LastName = Console.ReadLine();
                Console.WriteLine("Enter town: ");
                employee.Town = Console.ReadLine();
                Console.WriteLine("Enter salary: ");
                employee.Salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter department name: ");
                employee.DepartmentName = Console.ReadLine();
                productBusiness.Update(employee);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void Add()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter FirstName: ");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            employee.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter town: ");
            employee.Town = Console.ReadLine();
            Console.WriteLine("Enter department name: ");
            employee.DepartmentName = Console.ReadLine();
            productBusiness.Add(employee);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "EMPLOYEES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var employees = productBusiness.GetAll();
            foreach (var item in employees)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.FirstName, item.LastName, item.Salary, item.Town, item.DepartmentName);
            }
        }
    }
}
