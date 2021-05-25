using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RealLabBook.Data;
using RealLabBook.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace RealLabBook.Controllers
{

    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        

        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                return RedirectToRoute(new
                {
                    controller = "Tools",
                    action = "index",
                });
            return View();
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string email, string password)
        {
            List<User> user = await _db.User.Where(d => d.email.Equals(email)).ToListAsync();
            var userData = user.OrderBy(item => item.id).FirstOrDefault();
            if (user.Count() == 0 || !BCrypt.Net.BCrypt.Verify(password, userData.password))
            {
                ModelState.AddModelError("email", "������������ʼ�ҹ���١��ͧ");
                ModelState.AddModelError("password", "������������ʼ�ҹ���١��ͧ");
                var errorList = ModelState.Where(elem => elem.Value.Errors.Any()).ToDictionary(kvp => kvp.Key.Remove(0, kvp.Key.IndexOf('.') + 1), kvp => kvp.Value.Errors.Select(e => string.IsNullOrEmpty(e.ErrorMessage) ? e.Exception.Message : e.ErrorMessage).ToArray());
                var errorJSON = JsonConvert.SerializeObject(errorList);
                ViewBag.errors = JsonConvert.DeserializeObject(errorJSON);
                return View();
            }
            ClaimsIdentity identity = null;
            identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, userData.name),

                    new Claim(ClaimTypes.Surname, userData.surname),
                    new Claim(ClaimTypes.Email, userData.email),
                    new Claim(ClaimTypes.Role, userData.role),
                    //new Claim(ClaimTypes.Role, userData.role == "�Ҩ����" ? "Admin" : "User"),
                    new Claim(ClaimTypes.NameIdentifier, userData.id.ToString()),
            }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            return RedirectToRoute(new
            {
                controller = "Tools",
                action = "index",
            });
        }

        [Authorize]
        [Route("~/logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("LoginCookie", new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Secure = true,
            });
            return RedirectToRoute(new
            {
                controller = "Tools",
                action = "index",
            });
        }
    }
}