using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.AdminTrainModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class TrainAvailableController : BaseController<TrainAvailable,TrainAvailable,TrainAvailable>

    {
        public TrainAvailableController(IAdminTrainUow uow):base(uow) {}

    }
}
