using Microsoft.AspNetCore.Mvc;
using NinjaAPI_ForEvolve.Interfaces;

namespace NinjaAPI_ForEvolve.Controllers
{
    [Route("v1/[controller]")]
    public class SuperCoolController : Controller
    {
        private readonly IChildService _childService;

        public SuperCoolController(IChildService childService)
        {
            _childService = childService ?? throw new ArgumentNullException(nameof(childService));
        }

        [HttpGet]
        public void MySuperCoolMethod()
        {
            // some code here...
            _childService.DoSomething();
            // some more code here...
        }


    }
}
