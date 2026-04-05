using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

class CsvEncryption
{
    static readonly string key = "1234567890123456"; 
    static readonly string iv  = "6543210987654321"; 

    static void Main()
    {
        EncryptCsv("employees.csv", "employees_encrypted.csv");
        DecryptCsv("employees_encrypted.csv");
    }


    static void EncryptCsv(string input, string output)
    {
        string[] lines = File.ReadAllLines(input);
        List<string> encrypted = new List<string>();

        encrypted.Add(lines[0]); 

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            data[2] = Encrypt(data[2]); 
            data[3] = Encrypt(data[3]); 

            encrypted.Add(string.Join(",", data));
        }

        File.WriteAllLines(output, encrypted);
        Console.WriteLine("CSV encrypted successfully.");
    }

    static void DecryptCsv(string input)
    {
        string[] lines = File.ReadAllLines(input);

        Console.WriteLine("\nDecrypted Data:\n");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            data[2] = Decrypt(data[2]); 
            data[3] = Decrypt(data[3]); 

            Console.WriteLine(string.Join(" | ", data));
        }
    }

    
    static string Encrypt(string plainText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = Encoding.UTF8.GetBytes(iv);

        ICryptoTransform encryptor = aes.CreateEncryptor();

        byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
        byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

        return Convert.ToBase64String(encrypted);
    }

   
    static string Decrypt(string cipherText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = Encoding.UTF8.GetBytes(iv);

        ICryptoTransform decryptor = aes.CreateDecryptor();

        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        byte[] decrypted = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

        return Encoding.UTF8.GetString(decrypted);
    }
}
