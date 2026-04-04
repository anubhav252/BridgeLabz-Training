using System;
namespace ParcelTracker
{
    interface IParcelTrackerOperations
    {
        void AddStage(string stage);
        void AddCheckpoint(string stage, string checkpoint);
        void DisplayStages();
        void SimulateLoss(string stageName);
    }
}