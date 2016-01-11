using LewisList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LewisList.Controllers
{
    public class AppController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                var context = new ApplicationDbContext();
                var username = User.Identity.Name;

                if (!string.IsNullOrEmpty(username))
                {
                    var user = context.Users.SingleOrDefault(u => u.UserName == username);
                    //string fullName = string.Concat(new string[] { user.Firstname, " ", user.Lastname });
                    //ViewData.Add("FullName", fullName);
                }
            }
            base.OnActionExecuted(filterContext);
        }
        public AppController()
        { }
    }
}
