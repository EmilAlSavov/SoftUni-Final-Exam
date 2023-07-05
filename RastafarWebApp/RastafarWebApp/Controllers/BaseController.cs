using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RastafarWebApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
