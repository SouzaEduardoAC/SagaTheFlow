using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public class CreateCheckTasksForUnloadedPallets : Activity
    {
        public override void Run(ExecutionContext context)
        {
            context.Instance.HandleActivityFailure(
                context,
                null);
        }
    }
}