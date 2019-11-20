using System;
using SagaTheFlow.Contracts.InboundOrderAvailableFlow;
using SagaTheFlow.TheFlow;
using TheFlow.CoreConcepts;

namespace SagaTheFlow.Activities.InboundOrderAvailableFlow
{
    public class InboundOrderAvailableActivityFlow : IActivityFlow
    {
        public void StoreFlow()
        {
            var model = ProcessModel.Create(Guid.Parse("459f7fad-9ab9-45d5-aff9-f420d89477db"))
                .AddEventCatcherFor<InboundOrderAvailableToUnload>()
                .AddActivity<CreatePalletsToUnload>("CreatePalletsToUnload")
                .AddActivity<CreateCheckTasksForUnloadedPallets>("CreateCheckTasksForUnloadedPallets")
                .AddActivity<CancelCheckTasksForPallets>("CancelCheckTasksForPallets")
                .AttachAsCompensationActivity("CancelCheckTasksForPallets", "CreateCheckTasksForUnloadedPallets")
                .AddEventThrower<CheckTasksCreated>()
                .AddSequenceFlow("start", "CreatePalletsToUnload", "CreateCheckTasksForUnloadedPallets", "end");

            ProcessManagerHolder.Instance.ModelsStore.Store(model);
        }
    }
}