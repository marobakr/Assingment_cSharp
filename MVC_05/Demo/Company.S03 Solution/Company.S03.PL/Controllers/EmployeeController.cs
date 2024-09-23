using Company.S03.BLL.Interface;
using Company.S03.DAL.Models;
using Company.S03.PL.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Company.S03.PL.Controllers;

public class EmployeeController : Controller {
    private readonly IEmployeeRepositry _employeeRepository;
    private readonly IDepartmentRepository _departmentRepository;

    public EmployeeController(IEmployeeRepositry employeeRepository, IDepartmentRepository departmentRepository) 
    {
        _employeeRepository = employeeRepository;
        _departmentRepository = departmentRepository;
    }
/*=== === === === === === ===  Index === === === === === === === */
    public IActionResult Index(string InputSearch)
    { 
        var  employee = Enumerable.Empty<Employee>();
        if (string.IsNullOrEmpty(InputSearch))
        {
             employee  =  _employeeRepository.GetAll();
        }
        else
        {
            employee =  _employeeRepository.GetByName(InputSearch);
        }
        
        return View(employee);
        
        /*
         * View Dictionary: Transfer Data from Controller [Action] to View One Way
         * All property inhirtance from Controller Class
         * 1. ViewBag: Dynamic
         * 2. ViewDat: Dictionary
         * 3. TempData: transfer data from Request to another Request
         */
        // ViewData["Data01"] = "Hello From ViewData"; 
        // ViewBag.Data02 = "Hello From ViewBag";
        // TempData["Mssge"] = "Success Create Employee";
    }
    
    /*=== === === === === === ===  Create === === === === === === === */
    [HttpGet]
    public IActionResult Create()
    {
       var departments = _departmentRepository.GetAll();
       ViewData["departments"] = departments; 
       return View();
    }
    
    /*=== === === === === === ===  Create === === === === === === === */
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Employee model) {
        if (ModelState.IsValid)
        {
            /*
             * Mapping: Cast EmployeeViewModel to Employee
             * 1. Manual Mapping:
             * 2. Auto Mapping:
             */
            // Manual Mapping
            Employee employee = new Employee
                       {
                           Name = model.Name,
                           Id = model.Id,
                           Salary = model.Salary,
                           Address = model.Address,
                           Email = model.Email,
                           PhoneNumber = model.PhoneNumber,
                           Age = model.Age,
                           IsActive = model.IsActive,
                           HiringDate = model.HiringDate,
                           WorkForId = model.WorkForId
                       };
            
            var count = _employeeRepository.Add(employee);
            if (count > 0)
            {
                TempData["message"] = "Success Create Employee";
            }
            else
            {
                TempData["message"] = "Faile Create Employee";

            }
            return RedirectToAction("Index");

        }
      
        return View(model); 
    }

    /*=== === === === === === ===  Details === === === === === === === */
    [HttpGet]
    public IActionResult Details(int? id ,string viewName="Details")
    {
        if (id is null)
            return BadRequest("Id Not Found"); // 400
        var employee = _employeeRepository.Get(id.Value);
        
        if (employee is null) return NotFound();
        // Manual Mapping
        EmployeeViewModel employeeViewModel = new EmployeeViewModel()
        {
            Name = employee.Name,
            Id = employee.Id,
            Salary = employee.Salary,
            Address = employee.Address,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            Age = employee.Age,
            IsActive = employee.IsActive,
            HiringDate = employee.HiringDate,
            WorkForId = employee.WorkForId
        };
            
        return View(viewName,employee);
    }
    
    /*=== === === === === === ===  Edit === === === === === === === */
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var departments = _departmentRepository.GetAll();
        ViewData["departments"] = departments; 
        /* Repeated Code*/
        if (id is null) return BadRequest("Id Not Found"); // 400
        var employee = _employeeRepository.Get(id.Value);
        
        if (employee is null) return NotFound();
        
        return View(employee);
        return Details(id,"Edit");
    }

    /*=== === === === === === ===  Edit === === === === === === === */
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit([FromRoute]int? id ,Employee model)
    {
        try
        {
            if (id != model.Id) return BadRequest("Id Not Match"); // 400 
            if (ModelState.IsValid)
            {
                var count = _employeeRepository.Update(model);
                if (count > 0)
                {
                    return RedirectToAction("Index");
                }
            }
        }
        catch (Exception e)
        {
            ModelState.AddModelError(e + " ", "Error");
        }
      
        return View(model); 
    }
    
    /*=== === === === === === ===  Delete === === === === === === === */
    [HttpGet]
    public IActionResult Delete(int? id)
    {
        /* Reacted Code*/
        
        // if (id is null)
        //     return BadRequest("Id Not Found"); // 400
        // var department = _departmentRepository.Get(id.Value);
        //
        // if (department is null) return NotFound();
        //     
        // return View(department);
        return Details(id,"Delete");

    }
    
    /*=== === === === === === ===  Delete === === === === === === === */
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete([FromRoute]int? id ,Employee model)
    {
        try
        {
            if (id != model.Id) return BadRequest("Id Not Match"); // 400 
            if (ModelState.IsValid)
            {
                var count = _employeeRepository.Delete(model);
                if (count > 0)
                {
                    return RedirectToAction("Index");
                }
            }
        }
        catch (Exception e)
        {
            ModelState.AddModelError(e + " ", "Error");
        }
      
        return View(model); 
    }

}