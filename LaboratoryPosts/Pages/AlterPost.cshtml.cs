using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaboratoryPosts.Pages
{
    [Authorize]
    public class AlterPostModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}