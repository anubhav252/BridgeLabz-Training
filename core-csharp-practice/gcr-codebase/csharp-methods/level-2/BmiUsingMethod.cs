using System;
class BmiUsingMethod{
    static void Main(string[] args){
        double[,] personInfo = new double[10, 3];

        for (int i = 0; i < 10; i++){
            personInfo[i, 0] = double.Parse(Console.ReadLine()); 
            personInfo[i, 1] = double.Parse(Console.ReadLine()); 
        }
        CalculateBMI(personInfo);

     
        string[] status = GetBMIStatus(personInfo);

        for (int i = 0; i < 10; i++){
            Console.WriteLine(
                "Person " + (i + 1) +" Weight: " + personInfo[i, 0] +
				" Height: " + personInfo[i, 1] +" BMI: " + personInfo[i, 2] +
				" Status: " + status[i]
            );
        }
    }

    public static void CalculateBMI(double[,] personInfo){
        for (int i = 0; i < 10; i++){
            double weight = personInfo[i, 0];
            double heightInMeters = personInfo[i, 1] / 100; 

            double bmi = weight / (heightInMeters * heightInMeters);
            personInfo[i, 2] = bmi;
        }
    }

    public static string[] GetBMIStatus(double[,] personInfo){
        string[] status = new string[10];
        for (int i = 0; i < 10; i++){
            double bmi = personInfo[i, 2];

            if (bmi < 18.5)
                status[i] = "Underweight";
            else if (bmi < 25)
                status[i] = "Normal";
            else if (bmi < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
        return status;
    }
}
