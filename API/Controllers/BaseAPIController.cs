using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors(origins: "https://https://drop-shipping-spa.herokuapp.com", headers: "*", methods: "*")]
    [ApiController]
    [Route("api/[controller]")]

    public class BaseApiController : ControllerBase
    {
    }
}