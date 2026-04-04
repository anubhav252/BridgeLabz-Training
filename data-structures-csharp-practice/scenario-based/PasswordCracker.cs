using System;
using System.Text;
namespace PasswordCracker
{
    class Password
    {
        static char[] character={'c','d','e'};
        static string target = "ecd";
        static bool found = false;

        public void GetPassword(int targetLength)
        {
            StringBuilder currentPassword=new StringBuilder();
            GeneratePassword(0,targetLength,currentPassword);

        }
        public void GeneratePassword(int index,int targetLength,StringBuilder currentPassword)
        {
            if (found)
            {
                return;
            }
            if (index == targetLength)
            {
                if(currentPassword.ToString() == target)
                {
                    System.Console.WriteLine("Password found: " + currentPassword.ToString());
                    found = true;
                }
                System.Console.WriteLine(currentPassword.ToString()+" , ");
                return;
            }
            
            for (int i = 0; i < character.Length; i++)
            {
                currentPassword.Append(character[i]);
                GeneratePassword(index + 1, targetLength, currentPassword);
                currentPassword.Remove(currentPassword.Length - 1,1);
            }
            
        }
        static void Main(string[] args)
        {
            Password password = new Password();
            password.GetPassword(3);
        }
    }
}