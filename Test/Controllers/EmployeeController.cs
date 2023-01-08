using System.Collections.Generic;
using System.Diagnostics;
using HR;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
namespace Test.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult ShowAll()
    {

        ViewData["allemployees"] = UIManager.GetAllEmployees();

        return View();
    }
[HttpGet]
    public IActionResult ShowById()
    {
        return View();
    }

[HttpGet]
    public IActionResult Search()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Search(int id)
    {
        var employee = UIManager.GetEmployeeById(id);
        return View("ShowById", employee);
    }



    [HttpGet]
    public IActionResult Insert()
    {

        Employee employee = new Employee();
        return View(employee);

    }

    [HttpPost]
    public IActionResult Insert(Employee employee)
    {

        UIManager.InsertEmployee(employee);

        return RedirectToAction("ShowAll", "Employee");
    }



    [HttpGet]
    public IActionResult Update(int id)
    {
        Employee employee = UIManager.GetEmployeeById(id);
        return View(employee);
    }
    [HttpPost]
    public IActionResult Update(Employee employee)
    {
        UIManager.UpdateEmployee(employee);
        return RedirectToAction("ShowAll", "Employee");
    }


    [HttpGet]
    public IActionResult Delete(int id)
    {
        Employee employee = UIManager.GetEmployeeById(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        UIManager.DeleteEmployee(employee.Id);
        return RedirectToAction("ShowAll", "Employee");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
