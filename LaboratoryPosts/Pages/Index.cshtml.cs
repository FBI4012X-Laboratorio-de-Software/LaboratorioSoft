using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LaboratoryPosts.Data;
using LaboratoryPosts.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LaboratoryPosts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserService _userService;

        [BindProperty]
        public User UserModel { get; set; } = new User();

        public IndexModel(UserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            var usr = await _userService.FindAsync(UserModel);
            if (usr == null)
            {
                ModelState.AddModelError(string.Empty, "Usuario ou senha inválidos.");
                return Page();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserModel.Login)
            };

            var userIndentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIndentity);
            await HttpContext.SignInAsync(principal);
            return Redirect("/AdministrativePanel");
        }
    }
}
