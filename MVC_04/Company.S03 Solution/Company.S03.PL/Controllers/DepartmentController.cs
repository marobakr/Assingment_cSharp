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
/*=== === === === === === ===  Index === === === === === === === */
    [HttpGet]
    public IActionResult Index()
    {
     var department  =  _departmentRepository.GetAll();
        return View(department);
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

    /*=== === === === === === ===  Details === === === === === === === */
    [HttpGet]
    public IActionResult Details(int? id ,string viewName="Details")
    {
        if (id is null)
            return BadRequest("Id Not Found"); // 400
        var department = _departmentRepository.Get(id.Value);
        
        if (department is null) return NotFound();
            
        return View(viewName,department);
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
    public IActionResult Edit([FromRoute]int? id ,Department model)
    {
        try
        {
            if (id != model.Id) return BadRequest("Id Not Match"); // 400 
            if (ModelState.IsValid)
            {
                var count = _departmentRepository.Update(model);
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
    public IActionResult Delete([FromRoute]int? id ,Department model)
    {
        try
        {
            if (id != model.Id) return BadRequest("Id Not Match"); // 400 
            if (ModelState.IsValid)
            {
                var count = _departmentRepository.Delete(model);
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