using Org.BouncyCastle.Utilities.Encoders;

public class Program
{
    public static void Main(string[] args)
    {

        //SM2Encryption.GenerateSM2KeyPair(out string privateKey, out string publicKey);
        string privateKey = "Ja4UIUJz7XRNDhIiuWXwL78qd1Pc7SC0/Z9LzyF4SL8=";
        string publicKey = "BGe1BZDFN+NhCQtc2qlVk8nUlXrIwcyjT3mMt7Xx3BkDNBGBQjFPV0+h3/cGUYXo2TFI1SShS7hWl9zi6SxUHvg=";

        string raw = "Hello, SM2 Encryption!";
        string e = SM2Encryption.Encrypt(raw, publicKey);
        Console.WriteLine($"加密结果：{e}");

        string d = SM2Encryption.Decrypt(e, privateKey);
        Console.WriteLine($"解密结果：{d}");


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
        string encryptMsg = SM4Encryption.Encrypt(msg, key, iv, mode, false);
        string decryptedMsg = SM4Encryption.Decrypt(encryptMsg, key, iv, mode, false);

        //Hex
        string encryptMsgHex = SM4Encryption.Encrypt(msg, key, iv, mode, true);
        string decryptedMsgHex = SM4Encryption.Decrypt(encryptMsgHex, key, iv, mode, true);
        // 打印加密相关信息  

        Console.WriteLine("Message:\t\t{0}", encryptMsg);
        Console.WriteLine("decryptedMsg:\t\t{0}", decryptedMsg);
        Console.WriteLine("MessageHex:\t\t{0}", encryptMsgHex);
        Console.WriteLine("decryptedMsgHex:\t{0}", decryptedMsgHex);

    }


}

