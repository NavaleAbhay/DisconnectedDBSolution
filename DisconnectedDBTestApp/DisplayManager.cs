using HR;

public class DisplayManager
{

    public static void ShowMainMenu()
    {
        Console.WriteLine("  Choose Option : \n");
        Console.WriteLine("1. Department Operations");
        Console.WriteLine("2. Employee Operations\n");
    }

    public static void ShowDepartmentMenu()
    {
        Console.WriteLine("  Choose Option : \n");
        Console.WriteLine("0.***Exit***");
        Console.WriteLine("1.List");
        Console.WriteLine("2.Details");
        Console.WriteLine("3.Insert");
        Console.WriteLine("4.Update");
        Console.WriteLine("5.Delete");
        Console.WriteLine();
        Console.WriteLine("Department Operations");
        Console.WriteLine();
    }

    public static void ShowEmployeeMenu()
    {
        Console.WriteLine("  Choose Option : \n");
        Console.WriteLine("0.***Exit***");
        Console.WriteLine("1.List ");
        Console.WriteLine("2.Details");
        Console.WriteLine("3.Insert");
        Console.WriteLine("4.Update");
        Console.WriteLine("5.Delete");
        Console.WriteLine();
        Console.WriteLine("Employee Operations");
        Console.WriteLine();
    }
    public static void ShowAllDepartment()
    {
        List<Department> departments = UIManager.GetAllDepartments();
        foreach (Department department in departments)
        {
            Console.WriteLine(department.Id + " " + department.Name + "  " + department.Location);
        }
    }

    public static void ShowDepartmentById()
    {
        Console.WriteLine("Enter Department Id");
        int id = int.Parse(Console.ReadLine());
        Department departments = UIManager.GetDepartmentById(id);

        Console.WriteLine(departments.Id + " " + departments.Name + "  " + departments.Location);

    }

    public static void InsertDepartment()
    {
        Department dept = new Department();
        Console.WriteLine("Enter Department Name");
        dept.Name = Console.ReadLine();
        Console.WriteLine("Enter Department Location");
        dept.Location = Console.ReadLine();
        bool status = UIManager.InsertDepartment(dept);
        if (status)
        {
            Console.WriteLine("Department inserted successfully");
        }
        else
        {
            Console.WriteLine("Error while Inserted Department Information");
        }
    }

    public static void UpdateDepartment()
    {
        Department dept = new Department();
        Console.WriteLine("Enter Department Id");
        dept.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Department New Name");
        dept.Name = Console.ReadLine();
        Console.WriteLine("Enter Department New Location");
        dept.Location = Console.ReadLine();
        bool status = UIManager.UpdateDepartment(dept);
        if (status)
        {
            Console.WriteLine("Department Updated successfully");
        }
        else
        {
            Console.WriteLine("Error while Updating Department Information");
        }
    }

    public static void DeleteDepartment()
    {
        Console.WriteLine("Enter Department Id to Delete");
        int id = int.Parse(Console.ReadLine());
        bool status = UIManager.DeleteDepartment(id);
        if (status)
        {
            Console.WriteLine("Department Deleted successfully");
        }
        else
        {
            Console.WriteLine("Error while Deleting Department Information");
        }
    }

    public static void ShowAllEmployees()
    {
        List<Employee> employees = UIManager.GetAllEmployees();
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.Id + "__" + employee.FirstName + "__" + employee.LastName + "__" + employee.Email + "__" + employee.Address + "__" + employee.Password + "__" + employee.DeptId + "__" + employee.ManagerId);
        }
    }

    public static void ShowEmployeeById()
    {
        Console.WriteLine("Enter employee id:");
        int id = int.Parse(Console.ReadLine());
        Employee employee = UIManager.GetEmployeeById(id);
        Console.WriteLine(employee.Id + "__" + employee.FirstName + "__" + employee.LastName + "__" + employee.Email + "__" + employee.Address + "__" + employee.Password + "__" + employee.DeptId + "__" + employee.ManagerId);
    }

    public static void InsertEmployee()
    {
        Employee employee = new Employee();
        Console.WriteLine("Enter employee firstname:");
        employee.FirstName = Console.ReadLine();
        Console.WriteLine("Enter employee lastname:");
        employee.LastName = Console.ReadLine();
        Console.WriteLine("Enter employee email:");
        employee.Email = Console.ReadLine();
        Console.WriteLine("Enter employee address:");
        employee.Address = Console.ReadLine();
        Console.WriteLine("Enter employee password:");
        employee.Password = Console.ReadLine();
        Console.WriteLine("Enter employee department Id:");
        employee.DeptId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee manager Id:");
        employee.ManagerId = int.Parse(Console.ReadLine());
        bool status = UIManager.InsertEmployee(employee);
        if (status)
        {
            Console.WriteLine("Employee data inserted successfully");
        }
        else
        {
            Console.WriteLine("Error while Inserted employee Information");
        }
    }

    public static void UpdateEmployee()
    {
        Employee emp = new Employee();
        Console.WriteLine("Enter employee Id To Update:");
        emp.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee New firstname:");
        emp.FirstName = Console.ReadLine();
        Console.WriteLine("Enter employee New lastname:");
        emp.LastName = Console.ReadLine();
        Console.WriteLine("Enter employee New email:");
        emp.Email = Console.ReadLine();
        Console.WriteLine("Enter employee New address:");
        emp.Address = Console.ReadLine();
        Console.WriteLine("Enter employee New password:");
        emp.Password = Console.ReadLine();
        Console.WriteLine("Enter employee New department Id:");
        emp.DeptId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee New manager Id:");
        emp.ManagerId = int.Parse(Console.ReadLine());
        bool status = UIManager.UpdateEmployee(emp);
        if (status)
        {
            Console.WriteLine("Employee data Updated successfully");
        }
        else
        {
            Console.WriteLine("Error while Updating employee Information");
        }
    }

    public static void DeleteEmployee()
    {
        Console.WriteLine("Enter Department Id to Delete");
        int id = int.Parse(Console.ReadLine());
        bool status = UIManager.DeleteEmployee(id);
        if (status)
        {
            Console.WriteLine("Employee Deleted successfully");
        }
        else
        {
            Console.WriteLine("Error while Deleting Employee Information");
        }
    }
}
