using System;
namespace FitnessTrackerBubbleSort
{
    interface IAppOperation
    {
        void UpdateData(Data[] data);
        void SortDataBySteps(Data[] data);
        void DisplayData(Data[] data);
    }
}