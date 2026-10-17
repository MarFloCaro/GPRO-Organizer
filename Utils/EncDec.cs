
// Type: go.Utils.EncDec



using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

#nullable disable
namespace go.Utils
{
  public class EncDec
  {
    private static readonly byte[] Salt = new byte[]
    {
      73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118
    };

    public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      using (Aes aes = Aes.Create())
      {
        aes.Key = Key;
        aes.IV = IV;
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
          cryptoStream.Write(clearData, 0, clearData.Length);
          cryptoStream.Close();
          return memoryStream.ToArray();
        }
      }
    }

    public static string Encrypt(string clearText, string Password)
    {
      byte[] bytes = Encoding.Unicode.GetBytes(clearText);
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      {
        return Convert.ToBase64String(Encrypt(bytes, pdb.GetBytes(32), pdb.GetBytes(16)));
      }
    }

    public static byte[] Encrypt(byte[] clearData, string Password)
    {
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      {
        return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
      }
    }

    public static void Encrypt(string fileIn, string fileOut, string Password)
    {
      using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
      using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      using (Aes aes = Aes.Create())
      {
        aes.Key = pdb.GetBytes(32);
        aes.IV = pdb.GetBytes(16);
        using (CryptoStream cryptoStream = new CryptoStream(fsOut, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
          byte[] buffer = new byte[4096];
          int count;
          do
          {
            count = fsIn.Read(buffer, 0, buffer.Length);
            cryptoStream.Write(buffer, 0, count);
          }
          while (count != 0);
        }
      }
    }

    public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      using (Aes aes = Aes.Create())
      {
        aes.Key = Key;
        aes.IV = IV;
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
        {
          cryptoStream.Write(cipherData, 0, cipherData.Length);
          cryptoStream.Close();
          return memoryStream.ToArray();
        }
      }
    }

    public static string Decrypt(string cipherText, string Password)
    {
      byte[] cipherData = Convert.FromBase64String(cipherText);
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      {
        return Encoding.Unicode.GetString(Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16)));
      }
    }

    public static byte[] Decrypt(byte[] cipherData, string Password)
    {
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      {
        return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
      }
    }

    public static void Decrypt(string fileIn, string fileOut, string Password)
    {
      using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
      using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
      using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, Salt))
      using (Aes aes = Aes.Create())
      {
        aes.Key = pdb.GetBytes(32);
        aes.IV = pdb.GetBytes(16);
        using (CryptoStream cryptoStream = new CryptoStream(fsOut, aes.CreateDecryptor(), CryptoStreamMode.Write))
        {
          byte[] buffer = new byte[4096];
          int count;
          do
          {
            count = fsIn.Read(buffer, 0, buffer.Length);
            cryptoStream.Write(buffer, 0, count);
          }
          while (count != 0);
        }
      }
    }
  }
}
