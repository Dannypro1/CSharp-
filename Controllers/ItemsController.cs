using Microsoft.AspNetCore.Mvc;
using Webapp.Models;

namespace Webapp.Controllers;

public class ItemsController : Controller
{
    // GET
    public IActionResult Overview()
    {
        var item = new Items(){Id = 1, Name = "Sam"};
        return View(item);
    }

    public IActionResult Edit(int itemid)
    {
        return Content(" id= " +itemid);
    }
        
}