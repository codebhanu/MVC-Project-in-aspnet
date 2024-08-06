using GroceryStoreWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly UserManager<GroceryStoreWebAppUser> _userManager;

    public AdminController(UserManager<GroceryStoreWebAppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult ManageRoles()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ManageRoles(string userEmail, string roleName)
    {
        var user = await _userManager.FindByEmailAsync(userEmail);
        if (user != null)
        {
            var result = await _userManager.AddToRoleAsync(user, roleName);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error while adding user to role.");
            }
        }
        else
        {
            ModelState.AddModelError(string.Empty, "User not found.");
        }
        return View();
    }
}
