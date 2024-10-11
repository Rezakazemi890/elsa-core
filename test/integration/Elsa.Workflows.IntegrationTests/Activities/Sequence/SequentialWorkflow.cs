using Elsa.Workflows.Activities;

namespace Elsa.Workflows.IntegrationTests.Activities;

class SequentialWorkflow : WorkflowBase
{
    protected override void Build(IWorkflowBuilder workflow)
    {
        workflow.Root = new Sequence
        {
            Activities =
            {
                new WriteLine("Line 1"),
                new WriteLine("Line 2"),
                new WriteLine("Line 3")
            }
        };
    }
}