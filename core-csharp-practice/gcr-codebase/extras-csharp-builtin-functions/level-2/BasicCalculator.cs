using System;
class BasicCalculator{
    static void Main(string[] args){
        double num1 = GetNumber();
        double num2 = GetNumber();
        char operation = GetOperation();

        double result;

        if (operation == '+'){
            result = Add(num1, num2);
        }
        else if (operation == '-'){
            result = Subtract(num1, num2);
        }
        else if (operation == '*'){
            result = Multiply(num1, num2);
        }
        else if (operation == '/'){
            if (num2 == 0){
                Console.WriteLine("invalid input");
                return;
            }
            result = Divide(num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return;
        }

        DisplayResult(result);
    }

    static double GetNumber(){
        return double.Parse(Console.ReadLine());
    }

    static char GetOperation(){
        return char.Parse(Console.ReadLine());
    }

    static double Add(double a, double b){
        return a + b;
    }

    static double Subtract(double a, double b){
        return a - b;
    }
	
	static double Divide(double a, double b){
        return a / b;
    }

    static double Multiply(double a, double b){
        return a * b;
    }

    

    static void DisplayResult(double result){
        Console.WriteLine("Result: " + result);
    }
}
