using System;
using TheFlow.CoreConcepts;
using TheFlow.Elements.Events;

namespace SagaTheFlow.Contracts.InboundOrderAvailableFlow
{
    public class CheckTasksCreated : IEventThrower
    {
        public void Throw(ExecutionContext context)
        {
            Console.WriteLine("Dunno...");
        }
    }
}