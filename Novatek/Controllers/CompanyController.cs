using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novatek.Data;
using Novatek.Models.Entities;
using Novatek.Models.ViewModels;

namespace Novatek.Controllers
{
    public class CompanyController : Controller
    {
        private readonly NovatekDbContext context;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public CompanyController(NovatekDbContext context, IWebHostEnvironment hostEnv, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this._hostEnv = hostEnv;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(context.Companies?.ToList());
        }

        // Create New Company
        public IActionResult Create()
        {
            return View();
        }

        // Create New Company HTTP POST METHOD

        [HttpPost]
        public IActionResult Create(CompanyVM vm)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    if (vm.CompanyName != null)
                    {

                        Company co = new Company
                        {
                            CompanyName = vm.CompanyName,
                            CompanyAddress = vm.CompanyAddress,
                            City = vm.City,
                            Country = vm.Country,
                            Phone = vm.Phone,
                            FoundedDate = vm.FoundedDate
                        };
                        context.Companies?.Add(co);
                        context.SaveChanges();
                        return PartialView("_Success");
                    }

                }
                else
                {
                    return PartialView("_Error");
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }

            return View();

        }


        public IActionResult Update(int? id)
        {
            Company co = context.Companies.Find(id);

            CompanyVM vm = new CompanyVM
            {
                Id = co.Id,
                CompanyName = co.CompanyName,
                CompanyAddress = co.CompanyAddress,
                City = co.City,
                Country = co.Country,
                Phone = co.Phone,
                FoundedDate = co.FoundedDate
            };
            return View(vm);
        }


        [HttpPost]
        public IActionResult Update(CompanyVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (vm.CompanyName != null)
                    {

                        Company co = new Company
                        {
                            Id = vm.Id,
                            CompanyName = vm.CompanyName,
                            CompanyAddress = vm.CompanyAddress,
                            City = vm.City,
                            Country = vm.Country,
                            Phone = vm.Phone,
                            FoundedDate = vm.FoundedDate
                        };

                        context.Entry(co).State = EntityState.Modified;
                        context.SaveChanges();
                        return PartialView("_UpdateSuccess");
                    }
                    else
                    {
                        Company co = new Company
                        {
                            Id = vm.Id,
                            CompanyName = vm.CompanyName,
                            CompanyAddress = vm.CompanyAddress,
                            City = vm.City,
                            Country = vm.Country,
                            Phone = vm.Phone,
                            FoundedDate = vm.FoundedDate
                        };
                        context.Entry(co).State = EntityState.Modified;
                        context.SaveChanges();
                        return PartialView("_UpdateSuccess");
                    }
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
      
            return View();
        }

        // Delete Data

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Company co = context.Companies.Find(id);
                context.Companies.Remove(co);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        // Method For Not Found Exception
        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }


    }
}
