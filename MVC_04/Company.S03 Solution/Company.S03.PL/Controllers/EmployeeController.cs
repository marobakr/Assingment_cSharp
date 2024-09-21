using Company.S03.BLL.Interface;
using Company.S03.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.S03.PL.Controllers;

public class EmployeeController : Controller {
    private readonly IEmployeeRepositry _employeeRepository;

    public EmployeeController(IEmployeeRepositry employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
/*=== === === === === === ===  Index === === === === === === === */
    [HttpGet]
    public IActionResult Index()
    {
     var employees  =  _employeeRepository.GetAll();
        return View(employees);
    }
    
    /*=== === === === === === ===  Create === === === === === === === */
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    /*=== === === === === === ===  Create === === === === === === === */
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Employee model) {
        if (ModelState.IsValid)
        {
            var count = _employeeRepository.Add(model);
            if (count > 0)
            {   return RedirectToAction("Index");}
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
            
        return View(viewName,employee);
    }
    
    /*=== === === === === === ===  Edit === === === === === === === */
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        /* Reacted Code*/
        // if (id is null)
        //     return BadRequest("Id Not Found"); // 400
        // var department = _departmentRepository.Get(id.Value);
        //
        // if (department is null) return NotFound();
        //     
        // return View(department);
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