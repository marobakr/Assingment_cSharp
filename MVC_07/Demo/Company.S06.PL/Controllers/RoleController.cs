using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Demo.DAL.Models;
using Mvc03.Demo.PL.ViewModels.Role;

namespace Mvc03.Demo.PL.Controllers;

public class RoleController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;
    public readonly UserManager<ApplicationUser> _userManager;

    public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    #region Index

    public async Task<IActionResult> Index(string searchString)
    {
        var roles = Enumerable.Empty<RoleViewModel>();
        if (string.IsNullOrEmpty(searchString))
        {
            roles = await _roleManager.Roles.Select(R => new RoleViewModel()
                {
                    Id = R.Id,
                    RoleName = R.Name
                }
            ).ToListAsync();
        }
        else
        {
            roles = await _roleManager.Roles.Where(u => u.Name
                    .ToLower()
                    .Contains(searchString.ToLower()))
                .Select(u => new RoleViewModel()
                {
                    Id = u.Id,
                    RoleName = u.Name
                }).ToListAsync();
        }

        return View(roles);
    }

    #endregion

    #region Details

    [HttpGet]
    public async Task<IActionResult> Details(string? id, string viewName = "Details")
    {
        if (id is null) return BadRequest();
        var roleFromDb = await _roleManager.FindByIdAsync(id);
        if (roleFromDb == null) return BadRequest();
        var role = new RoleViewModel
        {
            Id = roleFromDb.Id,
            RoleName = roleFromDb.Name
        };
        return View(viewName, role);
    }

    #endregion

    #region Create

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    /*=== === === === === === ===  Create === === === === === === === */

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(RoleViewModel model)
    {
        if (ModelState.IsValid)
        {
            var role = new IdentityRole()
            {
                Name = model.RoleName
            };

            await _roleManager.CreateAsync(role);
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    #endregion

    [HttpGet]
    /*=== === === === === === ===  Update === === === === === === === */


    public async Task<IActionResult> Update(string? id)
    {
        return await Details(id, "Update");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([FromRoute] string? id, RoleViewModel model)
    {
        if (id != model.Id) return BadRequest();

        if (ModelState.IsValid)
        {
            var roleFromDb = await _roleManager.FindByIdAsync(id);
            if (roleFromDb == null) return BadRequest();
            roleFromDb.Name = model.RoleName;
            await _roleManager.UpdateAsync(roleFromDb);

            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }


}