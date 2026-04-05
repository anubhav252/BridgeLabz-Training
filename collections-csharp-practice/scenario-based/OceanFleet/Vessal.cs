using System;
namespace OceanFleet
{
    class Vessal
    {
        public string VessalId{get;}
        public string VessalName{get;}
        public double AverageSpeed{get;set;}
        public string VessalType{get;}
        public Vessal(string vessalId,string vessalName,double averageSpeed,string vessalType)
        {
            VessalId=vessalId;
            VessalName=vessalName;
            AverageSpeed=averageSpeed;
            VessalType=vessalType;
        }
    }
}