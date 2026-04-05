using System.ComponentModel;
using System.Net.Http.Headers;

namespace HazardAnalyzer
{
    class RobotSafetyException : Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
            
        }
    }
    class RobotHazardAuditor
    {
        public double CalculateHazardRisk(double armPrecision,int workerDensity,string machineryState)
        {
            try
            {
                ValidateFields(armPrecision,workerDensity,machineryState);
                double hazardRisk=0;
                double machineRiskFactor=0;
                if (machineryState == "Worn")
                {
                    machineRiskFactor=1.3;   
                }
                else if (machineryState == "Faulty")
                {
                    machineRiskFactor=2.0;
                }
                else
                {
                    machineRiskFactor=3.0;
                }

                hazardRisk=((1.0-armPrecision)*15.0)+(workerDensity*machineRiskFactor);
                return hazardRisk;
            }
            catch(RobotSafetyException e)
            {
                throw new RobotSafetyException(e.Message);
            }      
        }

        private void ValidateFields(double armPrecision,int workerDensity,string machineryState)
        {
            if(armPrecision<0.0 || armPrecision>1.0)
            {
                throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
            }
            if(workerDensity<1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error:Worker density must be 1-20");
            }
            string states="Worn Faulty Critical";
            if(!states.Contains(machineryState))
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }
        }

        static void Main(string[] args)
        {
            RobotHazardAuditor obj=new RobotHazardAuditor();
            System.Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Worker Density (1-20):");
            int workerDensity=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState=Console.ReadLine();
            try
            {
                System.Console.WriteLine("Robot Hazard Risk Score :"+obj.CalculateHazardRisk(armPrecision,workerDensity,machineryState));
            }
            catch(RobotSafetyException e)
            {
                System.Console.WriteLine(e.Message);
            }
             
        }
    }
}