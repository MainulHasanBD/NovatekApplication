using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Novatek.Data;
using Novatek.Models.Entities;

namespace Novatek.Controllers
{
    public class DesignationController : Controller
    {
        private readonly NovatekDbContext context;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public DesignationController(NovatekDbContext context, IWebHostEnvironment hostEnv, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this._hostEnv = hostEnv;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(context.Designations?.ToList());
        }
    }
}
