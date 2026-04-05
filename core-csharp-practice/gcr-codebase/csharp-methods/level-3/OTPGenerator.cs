using System;
class OTPGenerator{
    static void Main(string[] args){
        int[] otps = new int[10];

        for (int i = 0; i < otps.Length; i++){
            otps[i] = GenerateOTP();
            Console.WriteLine("Generated OTP " + (i + 1) + " = " + otps[i]);
        }

        bool isUnique = AreUnique(otps);

        if (isUnique)
            Console.WriteLine("All generated OTPs are unique");
        else
            Console.WriteLine("Duplicate OTPs found");
    }
    static int GenerateOTP(){
        Random random = new Random(Guid.NewGuid().GetHashCode());
        return random.Next(100000, 1000000);
    }
    static bool AreUnique(int[] otps){
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }

        return true;
    }
}
