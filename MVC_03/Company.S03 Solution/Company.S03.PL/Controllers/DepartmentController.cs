using Company.S03.BLL.Interface;
using Company.S03.BLL.Repositories;
using Company.S03.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.S03.PL.Controllers;

public class DepartmentController : Controller
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentController(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    [HttpGet]
    public IActionResult Index()
    {
     var department  =  _departmentRepository.GetAll();
        return View(department);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Department model)
    {
        if (ModelState.IsValid)
        {
            var count = _departmentRepository.Add(model);
            if (count > 0)
            {   return RedirectToAction("Index");}
        }
      
        return View(model); 
    }


    public IActionResult Details(int? id)
    {
        if (id is null)
            return BadRequest("Id Not Found"); // 400
        var department = _departmentRepository.Get(id.Value);
        
        if (department is null) return NotFound();
            
        return View(department);
    }
    

}