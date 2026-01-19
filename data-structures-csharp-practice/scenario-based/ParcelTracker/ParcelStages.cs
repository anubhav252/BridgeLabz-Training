using System;
namespace ParcelTracker
{
    class StageNode
    {
        public string Stage;
        public StageNode NextStage;
        public StageNode(string stage)
        {
            Stage=stage;
            NextStage=null;
        }
    }
}