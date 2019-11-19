using Microsoft.AspNetCore.Mvc;
using SagaTheFlow.Contracts.InboundOrderAvailableFlow;
using SagaTheFlow.TheFlow;

namespace StartUp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InboundOrderController : ControllerBase
    {
        [HttpGet]
        public void StartFlow()
        {
            ProcessManagerHolder.Instance.HandleEvent(new InboundOrderAvailableToUnload());
        }
    }
}