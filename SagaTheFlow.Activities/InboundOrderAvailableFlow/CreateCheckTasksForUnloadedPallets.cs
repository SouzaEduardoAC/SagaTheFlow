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
            Console.WriteLine("Let's say it failed somehow just to amuse me....");
            ProcessManagerHolder.Instance.HandleActivityFailure(
                context.Instance.Id,
                context.Token.Id,
                null);
        }
    }
}