using SagaTheFlow.TheFlow;
using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public sealed class CreatePalletsToUnload : Activity
    {
        public override void Run(ExecutionContext context)
        {
            ProcessManagerHolder.Instance.HandleActivityCompletion(context.Instance.Id, context.Token.Id, new CreateCheckTasksForUnloadedPallets());
        }
    }
}