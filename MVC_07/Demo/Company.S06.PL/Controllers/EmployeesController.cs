using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc.Demo.DAL.Models;
using Mvc03.Demo.BLL.Interfaces;
using Mvc03.Demo.BLL.Repositories;
using Mvc03.Demo.PL.Helper;
using Mvc03.Demo.PL.ViewModels.Employees;

namespace Mvc03.Demo.PL.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IEmployeeRepository _employeeRepository;
        //private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper mapper;

        public EmployeesController(
         //EmployeeRepository EmployeeRepository,
         // IDepartmentRepository DepartmentRepository, 
         IUnitOfWork unitOfWork,
            IMapper mapper
            )

        {
            //employeeRepository = EmployeeRepository;
            //_departmentRepository = DepartmentRepository;
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        /*=== === === === === === ===  Index === === === === === === === */
        public async Task<IActionResult> Index(string searchString)
        {
            var employees = Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(searchString))
            {
                employees =await _unitOfWork.EmployeeRepository.GetAllAsync();
            }
            else
            {
                employees =await _unitOfWork.EmployeeRepository.GetByNameAsync(searchString);
            }
            var Results = mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
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
            
            return View(Results);
        }
        [HttpGet]
        /*=== === === === === === ===  Create === === === === === === === */

        public async Task<IActionResult> Create()
        {
            var departments =await _unitOfWork.DepartmentRepository.GetAllAsync();
            ViewData["departments"] = departments;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel model)
        {
            //cast employeeViewModel to Employee
            //Mapping
            //1.Manual Mapping
            //Employee employee = new Employee()
            //{
            //    Id = model.Id,
            //    Name = model.Name,
            //    Address = model.Address,
            //    Salary = model.Salary,
            //    Age = model.Age,
            //    HiringDate = model.HiringDate,
            //    WorkFor = model.WorkFor,
            //    WorkForId = model.WorkForId,
            //    Email = model.Email,
            //    PhoneNumber = model.PhoneNumber,
            //    IsActive = model.IsActive,
            //};
            //2.Auto Mapping
            if (ModelState.IsValid)
            {
                if (model.Image is not null)
                {
                    model.ImageName = DocumentSettings.Upload(model.Image, "Images");
                }
                var employee = mapper.Map<Employee>(model);

                var Count =await _unitOfWork.EmployeeRepository.AddAsync(employee);
                if (Count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }
        [HttpGet]
        /*=== === === === === === ===  Details === === === === === === === */

        public async Task<IActionResult> Details(int? id, string viewName = "Details")
        {
            if (id is null) return BadRequest();

            var model = await _unitOfWork.EmployeeRepository.GetAsync(id.Value);
            if (model is null) return NotFound();

            var employeeViewModel = mapper.Map<EmployeeViewModel>(model);
            return View(viewName, employeeViewModel);
        }

        /*=== === === === === === ===  Update === === === === === === === */

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null) return BadRequest();

            var model =await _unitOfWork.EmployeeRepository.GetAsync(id.Value);
            if (model is null) return NotFound();

            var employeeViewModel = mapper.Map<EmployeeViewModel>(model);

            var departments =await _unitOfWork.DepartmentRepository.GetAllAsync();
            ViewData["departments"] = departments;

            return View("Update", employeeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromRoute] int? id, EmployeeViewModel model)
        {
            if (id != model.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                if (model.ImageName != null)
                {
                    DocumentSettings.Delete(model.ImageName, "Images");
                }
                if (model.Image is not null)
                {
                    model.ImageName = DocumentSettings.Upload(model.Image, "Images");
                }
                var employee = mapper.Map<Employee>(model);
                var count = await _unitOfWork.EmployeeRepository.UpdateAsync(employee);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            var departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
            ViewData["departments"] = departments;

            return View(model);
        }

        /*=== === === === === === ===  Delete === === === === === === === */

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var employee = await _unitOfWork.EmployeeRepository.GetAsync(id);
                if (employee == null) return NotFound();

                var Count =await _unitOfWork.EmployeeRepository.DeleteAsync(employee);
                if (Count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return BadRequest();
        }
    }
}
