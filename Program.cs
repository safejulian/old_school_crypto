using System;
using System.Security.Cryptography;
using System.Text;

public class Test
{
    public static string EncryptWithEcb(string message)
    {
        using Aes aes = Aes.Create(); ;

        byte[] input = Encoding.ASCII.GetBytes(message);
        aes.Mode = CipherMode.ECB;

        byte[] cipherText = aes.EncryptEcb(input, PaddingMode.Zeros);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < cipherText.Length; i++)
        {
            sb.Append(cipherText[i].ToString("X2"));
        }
        return sb.ToString();
    }

    public static string ComputeMd5Hash(string message)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] input = Encoding.ASCII.GetBytes(message);
            byte[] hash = md5.ComputeHash(input);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
    public static void Main()
    {
        string message = "Old School Dot Nets are not Bot Nets";
        Console.WriteLine(ComputeMd5Hash(message));
        string otherMessage = "Old school algos are not cool algos";
        Console.WriteLine(EncryptWithEcb(otherMessage));


    }
}