using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.AdminHotelModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]

    public class HotelController : BaseController<Hotel,Hotel,Hotel>

    {
        public HotelController(IAdminHotelUow uow):base(uow) {}

    }
}
