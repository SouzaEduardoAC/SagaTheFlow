using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public sealed class CreatePalletsToUnload : Activity
    {
        public override void Run(ExecutionContext context)
        {
            context.Instance.HandleActivityCompletion(context, new CreateCheckTasksForUnloadedPallets());
        }
    }
}