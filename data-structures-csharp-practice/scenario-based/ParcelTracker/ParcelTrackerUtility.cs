using System;
namespace ParcelTracker
{
    class ParcelTrackerUtility: IParcelTrackerOperations
    {
        private StageNode head;
        public void AddStage(string stage)
        {
            StageNode newNode=new StageNode(stage);
            if (head == null)
            {
                head=newNode;
                return;
            }
            StageNode current=head;
            while (current.NextStage != null)
            {
                current=current.NextStage;
            }
            current.NextStage=newNode;
        }
        public void AddCheckpoint(string stage, string checkpoint)
        {
            StageNode current=head;
            while (current != null)
            {
                if (current.Stage.Equals(stage, StringComparison.OrdinalIgnoreCase) )
                {
                    StageNode checkpointNode=new StageNode(checkpoint);
                    checkpointNode.NextStage=current.NextStage;
                    current.NextStage=checkpointNode;
                    return;
                }
                current=current.NextStage;
            }
        }
        public void DisplayStages()
        {
            StageNode current=head;

            Console.WriteLine("Parcel Stages-------------");
            while (current != null)
            {
                Console.WriteLine(" -> " + current.Stage);
                current=current.NextStage;
            }
        }
        public void SimulateLoss(string stageName)
        {
            StageNode current = head;

            while (current != null && current.NextStage!= null)
            {
                if (current.Stage.Equals(stageName, StringComparison.OrdinalIgnoreCase))
                {
                    current.NextStage= null;
                    Console.WriteLine("Parcel lost after stage: " + stageName);
                    return;
                }
                current = current.NextStage;
            }

            Console.WriteLine("Stage not found.");
        }
    }
}