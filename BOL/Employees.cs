using System.Net.Http.Headers;

namespace HR;

public class Employees
{
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string Address{get;set;}
    public string Password{get;set;}
    public int DeptId{get;set;}
    public int ManagerId{get;set;}
}