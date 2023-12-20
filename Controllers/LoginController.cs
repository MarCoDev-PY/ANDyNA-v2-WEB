using ANDyNA_v2.Data;
using ANDyNA_v2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;



namespace ANDyNA_v2.Controllers
{
    public class LoginController : Controller
    {
        private ANDyNA_v2Context _context;
        public LoginController(ANDyNA_v2Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(String email,String password) 
        {
            var usuario = await _context.Usuarios
                                        .Where(x => x.Cuenta == email && x.Password == password)
                                      .FirstOrDefaultAsync();
            if (usuario != null)
            {
               // await SetUserCookies(usuario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["LoginError"] = "Usuario o contraseña incorrecto!";
                return RedirectToAction("Index");
            }
            
        }

        /*private Task SetUserCookies(Usuarios usuario)
        {
            var claims = new List<Claim>()
            {
                
            };
        }*/

        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Inicio");
        }
    }
}
