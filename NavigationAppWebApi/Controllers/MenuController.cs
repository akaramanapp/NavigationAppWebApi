using Microsoft.AspNetCore.Mvc;
using NavigationAppWebApi.Dto;
using System.Collections.Generic;

namespace NavigationAppWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : Controller
    {
        [HttpGet]
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuList = new List<MenuItem>();
            MenuItem menuItem1 = new MenuItem
            {
                Name = "About",
                Path = "about"
            };

            MenuItem menuItem2 = new MenuItem
            {
                Name = "Dashboard",
                Path = "dashboard"
            };

            menuList.Add(menuItem1);
            menuList.Add(menuItem2);

            return menuList;
        }
    }
}
