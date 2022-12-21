using HR;
using DAL;
using System;
using System.Collections.Generic;

public class DisplayManager
{



    public static void ShowDepartmentMenu()
    {
        Console.WriteLine("Choose Option : \n");
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
       if(status){
        Console.WriteLine("Department Deleted successfully");
     }else{
        Console.WriteLine("Error while Deleting Department Information");
     }
    }
}