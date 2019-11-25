using System;
using SagaTheFlow.TheFlow;
using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public class CreateCheckTasksForUnloadedPallets : Activity
    {
        public override void Run(ExecutionContext context)
        {
            ProcessManagerHolder.Instance.HandleActivityFailure(
                context.Instance.Id,
                context.Token.Id,
                null);
        }
    }
}