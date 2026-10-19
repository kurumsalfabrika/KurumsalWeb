using Kurumsal.WebUI.Context;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.User
{
    [Authorize]
    public class RolController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RolController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public class Category
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }

        }

        public IActionResult Index()
        {

            return View(_roleManager.Roles.ToList());
        }

        public async Task<IActionResult> Kategoriler()
        {

            using var httpClient = new HttpClient();
            var responseMesaj = await httpClient.GetAsync("http://localhost:19787/api/home");

            var stringJson = await responseMesaj.Content.ReadAsStringAsync();

            var categories = JsonConvert.DeserializeObject<List<Category>>(stringJson);


            if (responseMesaj.StatusCode == System.Net.HttpStatusCode.OK)
            {

            }

            return View(categories);
        }



        public IActionResult Add()
        {
            return View(new RoleViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole
                {
                    Name = model.Name
                };
                var identityResult = await _roleManager.CreateAsync(role);
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }


        public IActionResult Update(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(I => I.Id == id);
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                Id = role.Id,
                Name = role.Name
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoleUpdateViewModel model)
        {
            var updateRole = _roleManager.Roles.Where(I => I.Id == model.Id).FirstOrDefault();

            updateRole.Name = model.Name;
            var identityResult = await _roleManager.UpdateAsync(updateRole);
            if (identityResult.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var item in identityResult.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {

            var deleteRole = _roleManager.Roles.Where(I => I.Id == id).FirstOrDefault();
            var identityResult = await _roleManager.DeleteAsync(deleteRole);


            if (identityResult.Succeeded)
            {
                return RedirectToAction("Index");
            }

            TempData["Errors"] = identityResult.Errors;
            return RedirectToAction("Index");

    
        }


        public async Task<IActionResult> RolAta(int id)
        {
            var user = _userManager.Users.FirstOrDefault(I => I.Id == id);
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);

            TempData["UserId"] = user.Id;

            List<RolAtaViewModel> models = new List<RolAtaViewModel>();

            foreach (var item in roles)
            {
                RolAtaViewModel model = new RolAtaViewModel();
                model.RolId = item.Id;
                model.Name = item.Name;
                model.Var = userRoles.Contains(item.Name);
                models.Add(model);
            }

            return View(models);
        }


        [HttpPost]
        public async Task<IActionResult> RolAta(List<RolAtaViewModel> models)
        {
            var userId = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(I => I.Id == userId);

            foreach (var item in models)
            {
                if(item.Var)
                {
                   await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }

            return RedirectToAction("Index","User");

        }

    }
}
