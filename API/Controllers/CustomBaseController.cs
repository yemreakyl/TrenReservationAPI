using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        //Bu classın amacı diğer controller classlarımın return kısmında yazmam gerekenok,badrequest vs tarzı ifadeyi elle yazmak yerine burda methot hazırlayıp statuscode da göre kendisinin otomatik yazmasını sağlamak maksadıyla yapıyorum
        [NonAction]//Endpoint olmadığını belirtiyorum
        public ActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null) { StatusCode = response.StatusCode };
            else
            {
                return new ObjectResult(response) { StatusCode = response.StatusCode };
            }
        }
    }
}
