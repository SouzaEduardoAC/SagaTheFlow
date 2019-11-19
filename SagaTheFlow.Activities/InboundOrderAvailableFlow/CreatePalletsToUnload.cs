using System;
using SagaTheFlow.TheFlow;
using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public class CreatePalletsToUnload : Activity
    {
        public override void Run(ExecutionContext context)
        {
            Console.WriteLine("CreatingPalletsToUnload...");
            ProcessManagerHolder.Instance.HandleActivityCompletion(context.Instance.Id, context.Token.Id, null);
        }
    }
}