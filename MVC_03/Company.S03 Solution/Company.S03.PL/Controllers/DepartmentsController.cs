using Company.S03.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company.S03.PL.Controllers;

public class DepartmentsController : Controller
{
    private readonly DepartmentRepository _departmentRepository;

    public DepartmentsController(DepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public IActionResult Index()
    {
     var department  =  _departmentRepository.GetAll();
        return View(department);
    }
}