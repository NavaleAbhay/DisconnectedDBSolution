using DAL;
using HR;

public class UIManager
{
    public static List<Department> GetAllDepartments()
    {
        return DisconnectedDBManager.GetAllDepartments();
    }

    public static Department GetDepartmentById(int id)
    {
        return DisconnectedDBManager.GetDepartmentById(id);
    }

    public static bool InsertDepartment(Department dept)
    {
        return DisconnectedDBManager.InsertDepartment(dept);
    }

    public static bool UpdateDepartment(Department dept)
    {
        return DisconnectedDBManager.UpdateDepartment(dept);
    }

    public static bool DeleteDepartment(int id)
    {
        return DisconnectedDBManager.DeleteDepartment(id);
    }

    public static List<Employee> GetAllEmployees()
    {
        return DisconnectedDBManager.GetAllEmployees();
    }

    public static Employee GetEmployeeById(int id)
    {
        return DisconnectedDBManager.GetEmployeeById(id);
    }

    public static bool InsertEmployee(Employee emp)
    {
        return DisconnectedDBManager.InsertEmployee(emp);
    }

    public static bool UpdateEmployee(Employee emp)
    {
        return DisconnectedDBManager.UpdateEmployee(emp);
    }

    public static bool DeleteEmployee(int id)
    {
        return DisconnectedDBManager.DeleteEmployee(id);
    }
}