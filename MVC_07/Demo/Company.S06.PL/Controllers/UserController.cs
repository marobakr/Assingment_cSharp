using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Demo.DAL.Models;
using Mvc03.Demo.PL.ViewModels.Employees;
using Mvc03.Demo.PL.ViewModels.User;

namespace Mvc03.Demo.PL.Controllers;

public class UserController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    /* Get,  Get, ALL, Update, Delete */
    /* Index, Details, Create=[SignIn], Edite, Delete */


    public UserController(UserManager<ApplicationUser> _userManager)
    {
        this._userManager = _userManager;
    }
    /*=== === === === === === ===  Index === === === === === === === */

    public async Task<IActionResult> Index(string searchString)
    {
        var users = Enumerable.Empty<UserViewModel>();
        if (string.IsNullOrEmpty(searchString))
        {
            users = await _userManager.Users.Select(U => new UserViewModel()
            {
                Id = U.Id,
                FirstName = U.FirstName,
                LastName = U.LastName,
                Email = U.Email,
                Roles = _userManager.GetRolesAsync(U).Result
            }).ToListAsync();
        }
        else
        {
            users = await _userManager.Users.Where(U => U.Email
                    .ToLower()
                    .Contains(searchString.ToLower()))
                .Select(U => new UserViewModel()
                {
                    Id = U.Id,
                    FirstName = U.FirstName,
                    LastName = U.LastName,
                    Email = U.Email,
                    Roles = _userManager.GetRolesAsync(U).Result
                }).ToListAsync();
        }

        return View(users);
    }


    [HttpGet]
    /*=== === === === === === ===  Details === === === === === === === */
    public async Task<IActionResult> Details(string? id, string viewName = "Details")
    {
        if (id is null) return BadRequest();
        var userFromDb = await _userManager.FindByIdAsync(id);
        if (userFromDb == null) return BadRequest();
        var user = new UserViewModel
        {
            Id = id,
            FirstName = userFromDb.FirstName,
            LastName = userFromDb.LastName,
            Email = userFromDb.Email,
            Roles = _userManager.GetRolesAsync(userFromDb).Result
        };
        return View(viewName, user);
    }
    /*=== === === === === === ===  Update === === === === === === === */
    [HttpGet]
    public async Task<IActionResult> Update(string? id)
    {
        return await Details(id, "Update");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([FromRoute] string? id, UserViewModel model)
    {
        if (id != model.Id) return BadRequest();

        if (ModelState.IsValid)
        {
            var userFromDb = await _userManager.FindByIdAsync(id);
            if (userFromDb == null) return BadRequest();
            userFromDb.FirstName = model.FirstName;
            userFromDb.LastName = model.LastName;
            userFromDb.Email = model.Email;
            await _userManager.UpdateAsync(userFromDb);

            return RedirectToAction(nameof(Index));

        }

        return View(model);
    }
    /*=== === === === === === ===  Delete === === === === === === === */

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(string id)
    {
        try
        {
            if (id != id) return BadRequest();

            if (ModelState.IsValid)
            {
                var userFromDb = await _userManager.FindByIdAsync(id);

                if (userFromDb is null)
                    return NotFound();


                await _userManager.DeleteAsync(userFromDb);
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