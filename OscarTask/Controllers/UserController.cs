using Microsoft.AspNetCore.Mvc;
using OscarTask.DBContext;
using OscarTask.Models;
using System.Linq;

namespace OscarTask.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var ExistingUser = _context.Users.ToList();

            return View(ExistingUser);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
           
                 _context.Users.Add(user);

                _context.SaveChanges();
                return RedirectToAction("Index");
          
            
        }

        public IActionResult Edit(int id)
        {
            var usertoedit= _context.Users.Find(id);

            return View(usertoedit);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            
                _context.Users.Update(user);

                  _context.SaveChanges();
                return RedirectToAction("Index");
            
        }

        public IActionResult Delete(int id)
        {
            var usertodelete = _context.Users.Find(id);
            return View(usertodelete);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var foudeduser = _context.Users.Find(id);
            if (foudeduser != null)
            {
                _context.Users.Remove(foudeduser);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var usertoshow = _context.Users.Find(id);

            return View(usertoshow);
        }
    }
}
