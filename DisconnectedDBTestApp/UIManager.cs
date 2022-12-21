using HR;
using DAL;
using System;
using System.Collections.Generic;

public class UIManager{
    public static List<Department> GetAllDepartments(){
       return DisconnectedDBManager.GetAllDepartments();
    }

     public static Department GetDepartmentById(int id){
      return DisconnectedDBManager.GetDepartmentById(id);
    }

    public static bool InsertDepartment(Department dept){
      return DisconnectedDBManager.InsertDepartment(dept);
    }

    public static bool UpdateDepartment(Department dept){
      return DisconnectedDBManager.UpdateDepartment(dept);
    }   

    public static bool DeleteDepartment(int id){
      return DisconnectedDBManager.DeleteDepartment(id);
    }

}