using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {

        //SM2Encryption.GenerateSM2KeyPair(out string privateKey, out string publicKey);
        string privateKey = "Ja4UIUJz7XRNDhIiuWXwL78qd1Pc7SC0/Z9LzyF4SL8=";
        string publicKey = "BGe1BZDFN+NhCQtc2qlVk8nUlXrIwcyjT3mMt7Xx3BkDNBGBQjFPV0+h3/cGUYXo2TFI1SShS7hWl9zi6SxUHvg=";

        string raw = "Hello, SM2 Encryption!";
        string e = SM2Encryption.EncryptBase64(raw, publicKey);
        Console.WriteLine($"加密结果(Base64)：{e}");

        string d = SM2Encryption.DecryptBase64(e, privateKey);
        Console.WriteLine($"解密结果(Base64)：{d}");


        //SM2Encryption.GenerateSM2KeyPair(out string privateKeyHex, out string publicKeyHex, true);
        string privateKeyHex = "891b2c80ce49547a3230aa813467602695e1be15a68df9d49588042c2019ab59";
        string publicKeyHex = "04c3fbf57d86c31594e5997919bd1dfe737686b1e49099d53b87937f02c386dd960a32c6d8771bb06caa11e6ce13ad88981516ee797ad31ee23254038b717359a3";
        string eHex = SM2Encryption.EncryptHex(raw, publicKeyHex);
        Console.WriteLine($"加密结果(Hex)：{eHex}");

        string dHex = SM2Encryption.DecryptHex(eHex, privateKeyHex);
        Console.WriteLine($"解密结果(Hex)：{dHex}");

        string data = "Hello, SM3 Encryption!";
        string sm3key = "98C63180C3748ED2";

        string sm3Hash = SM3Encryption.ComputeSM3HashBase64(data);
        string sm3HashHex = SM3Encryption.ComputeSM3HashHex(data);
        //sm3 with key
        byte[] hash = SM3Encryption.ComputeHMacSM3(data, sm3key);
        string stringHash = Base64.ToBase64String(hash);
        string a = SM3Encryption.ComputeSM3HashBase64(data);
        string hexHash = Hex.ToHexString(hash); // 如果需要十六进制字符串表示  

        Console.WriteLine("Original Data: " + data);
        Console.WriteLine("SM3 Hash(string): " + sm3Hash);
        Console.WriteLine("SM3 Hash(Hex): " + sm3HashHex);
        Console.WriteLine("HMAC-SM3 Hash (string): " + stringHash);
        Console.WriteLine("HMAC-SM3 Hash (Hex): " + hexHash);


        var msg = "Hello, SM4 Encryption!";
        string key = "98C63180C3748ED2";
        var iv = "UISwD9fW6cFh9SNS";
        var mode = "CBC";
        string encryptMsg = SM4Encryption.EncryptBase64(msg, key, iv, mode);
        string decryptedMsg = SM4Encryption.DecryptBase64(encryptMsg, key, iv, mode);


        byte[] keyBytes = GenerateRandomBytes(16); // 16 bytes = 128 bits
        string keyBase64 = Convert.ToBase64String(keyBytes);
        string keyHex = BitConverter.ToString(keyBytes).Replace("-", "").ToLower();
        Console.WriteLine("Generated Key (Hex): " + keyHex);
        Console.WriteLine("Generated Key (Base64): " + keyBase64);

        byte[] ivBytes = GenerateRandomBytes(16); // 16 bytes = 128 bits
        string ivBase64 = Convert.ToBase64String(ivBytes);
        string ivHex = BitConverter.ToString(ivBytes).Replace("-", "").ToLower();
        Console.WriteLine("Generated IV (Hex): " + ivHex);
        Console.WriteLine("Generated IV (Base64): " + ivBase64);
        //Hex
        string encryptMsgHex = SM4Encryption.EncryptHex(msg, keyHex, ivHex, mode);
        string decryptedMsgHex = SM4Encryption.DecryptHex(encryptMsgHex, keyHex, ivHex, mode);
        // 打印加密相关信息  

        Console.WriteLine("Message:\t\t{0}", encryptMsg);
        Console.WriteLine("decryptedMsg:\t\t{0}", decryptedMsg);
        Console.WriteLine("MessageHex:\t\t{0}", encryptMsgHex);
        Console.WriteLine("decryptedMsgHex:\t{0}", decryptedMsgHex);



    }

    public static byte[] GenerateRandomBytes(int length)
    {
        byte[] randomBytes = new byte[length];
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
        }
        return randomBytes;
    }
}

