using Microsoft.AspNetCore.Mvc;
using SagaTheFlow.Contracts.InboundOrderAvailableFlow;
using SagaTheFlow.TheFlow;

namespace SagaTheFlow
{
    [ApiController]
    [Route("[controller]")]
    public class InboundOrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult StartFlow()
        {
            ProcessManagerHolder.Instance.HandleEvent(new InboundOrderAvailableToUnload());
            return Ok("ok");
        }
    }
}