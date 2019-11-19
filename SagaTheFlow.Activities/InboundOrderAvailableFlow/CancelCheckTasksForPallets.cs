using System;
using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public class CancelCheckTasksForPallets : Activity
    {
        public override void Run(ExecutionContext context)
        {
            Console.WriteLine($"Cancelling check tasks for ID: {context.Instance.Id} with Token :{context.Token.Id}");
        }
    }
}