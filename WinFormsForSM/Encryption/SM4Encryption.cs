using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;

/// <summary>  
/// 加密工具类，提供基于SM4算法的加密和解密功能。  
/// </summary>  
public static class SM4Encryption
{

    /// <summary>  
    /// 使用SM4算法对指定明文进行加密。  
    /// </summary>  
    /// <param name="msg">待加密的明文。</param>  
    /// <param name="key">用于加密的密钥。</param>  
    /// <param name="iv">初始化向量，对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，默认为"ECB"。</param>  
    /// <returns>加密后的密文，格式为十六进制或Base64。</returns>  
    /// <exception cref="ArgumentNullException">当msg或key为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持时抛出。</exception>  
    /// <exception cref="CryptographicException">当加密过程中发生错误时抛出。</exception>  
    public static string EncryptBase64(string msg, string key, string iv, string mode = "ECB")
    {
        // 解密后的明文  
        byte[] cipherTextData = Encrypt(Encoding.UTF8.GetBytes(msg), Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(iv), mode);
        // 根据需求返回加密后的数据格式（Base64进制）  
        return Base64.ToBase64String(cipherTextData);
    }
    /// <summary>  
    /// 使用SM4算法对指定密文进行解密。  
    /// </summary>  
    /// <param name="encryptMsg">待解密的密文，Base64格式。</param>  
    /// <param name="key">用于解密的密钥。</param>  
    /// <param name="iv">初始化向量，对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，用于确定解密时使用的模式，默认为"ECB"。</param>  
    /// <returns>解密后的明文。</returns>  
    /// <exception cref="ArgumentNullException">当key或encryptMsg为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持或iv对于非ECB模式为空时抛出。</exception>  
    /// <exception cref="CryptographicException">当解密过程中发生错误时抛出。</exception>  
    public static string DecryptBase64(string encryptMsg, string key, string iv, string mode = "ECB")
    {
        // 解密后的明文  
        byte[] decryptedData = Decrypt(Convert.FromBase64String(encryptMsg), Encoding.UTF8.GetBytes( key), Encoding.UTF8.GetBytes(iv),mode);
        // 转换解密后的字节数组为字符串  
        string decryptedMsg = Encoding.UTF8.GetString(decryptedData);
        return decryptedMsg.TrimEnd('\0');
    }



    /// <summary>  
    /// 使用SM4算法对指定明文进行加密。  
    /// </summary>  
    /// <param name="msg">待加密的明文（Hex格式）。</param>  
    /// <param name="key">用于加密的密钥（字节数组形式）。</param>  
    /// <param name="iv">初始化向量（字节数组形式），对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，默认为"ECB"。</param>  
    /// <returns>加密后的密文，格式为十六进制。</returns>  
    /// <exception cref="ArgumentNullException">当msg或key为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持时抛出。</exception>  
    /// <exception cref="CryptographicException">当加密过程中发生错误时抛出。</exception>  
    public static string EncryptHex(string msg,string key, string iv, string mode = "ECB")
    {
        try
        {
            // 执行加密操作  
            byte[] cipherTextData = Encrypt(Encoding.UTF8.GetBytes(msg), Hex.Decode(key), Hex.Decode(iv), mode);

            // 根据需求返回加密后的数据格式（十六进制）  
            return Hex.ToHexString(cipherTextData);
        }
        catch (Exception ex)
        {
            // 处理加密过程中发生的异常  
            throw new CryptographicException("Encryption failed.", ex);
        }
    }

    /// <summary>  
    /// 使用SM4算法对指定密文进行解密。  
    /// </summary>  
    /// <param name="encryptMsg">待解密的密文（Hex格式）。</param>  
    /// <param name="key">用于解密的密钥（Hex格式）。</param>  
    /// <param name="iv">初始化向量（Hex格式），对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，用于确定解密时使用的模式，默认为"ECB"。</param>  
    /// <returns>解密后的明文Hex格式。</returns>  
    /// <exception cref="ArgumentNullException">当key或encryptMsg为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持或iv对于非ECB模式为空时抛出。</exception>  
    /// <exception cref="CryptographicException">当解密过程中发生错误时抛出。</exception>  
    public static string DecryptHex(string encryptMsg, string key, string iv, string mode = "ECB")
    {
        try
        {
           byte[] decryptedData= Decrypt(Convert.FromHexString(encryptMsg), Hex.Decode(key), Hex.Decode(iv), mode);
            // 转换解密后的字节数组为字符串  
            string decryptedMsg =Encoding.UTF8.GetString(decryptedData);
            return decryptedMsg.TrimEnd('\0');
        }
        catch (Exception ex)
        {
            // 处理解密过程中发生的异常  
            throw new CryptographicException("Decryption failed.", ex);
        }
    }

    /// <summary>  
    /// 使用SM4算法对指定明文进行加密。  
    /// </summary>  
    /// <param name="msg">待加密的明文（字节数组形式）。</param>  
    /// <param name="key">用于加密的密钥（字节数组形式）。</param>  
    /// <param name="iv">初始化向量（字节数组形式），对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，默认为"ECB"。</param>  
    /// <returns>加密后的密文，格式为十六进制。</returns>  
    /// <exception cref="ArgumentNullException">当msg或key为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持时抛出。</exception>  
    /// <exception cref="CryptographicException">当加密过程中发生错误时抛出。</exception>  
    public static byte[] Encrypt(byte[] plainTextData, byte[] key, byte[] iv, string mode = "ECB")
    {
        // 验证输入参数  
        if (plainTextData == null || plainTextData.Length == 0)
            throw new ArgumentNullException(nameof(plainTextData), "plainTextData cannot be null or empty.");
        if (key == null || key.Length == 0)
            throw new ArgumentNullException(nameof(key), "Key cannot be null or empty.");
        if (iv == null && mode != "ECB")
            throw new ArgumentNullException(nameof(iv), "IV is required for modes other than ECB.");

        var cipher = new SM4Engine();
        PaddedBufferedBlockCipher cipherMode;

        switch (mode)
        {
            case "ECB":
                cipherMode = new PaddedBufferedBlockCipher(new EcbBlockCipher(cipher), new Pkcs7Padding());
                break;
            case "CBC":
                cipherMode = new PaddedBufferedBlockCipher(new CbcBlockCipher(cipher), new Pkcs7Padding());
                break;
            // ... [其他模式的情况] ...  
            default:
                throw new ArgumentException("Unsupported mode: " + mode);
        }

        // 创建密钥参数  
        KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", key);
        ICipherParameters parameters = mode == "ECB" ? keyParam : new ParametersWithIV(keyParam, iv);

        // 初始化加密器  
        cipherMode.Init(true, parameters);

        // 准备输出缓冲区  
        byte[] cipherTextData = new byte[cipherMode.GetOutputSize(plainTextData.Length)];

        try
        {
            // 执行加密操作  
            int length1 = cipherMode.ProcessBytes(plainTextData, 0, plainTextData.Length, cipherTextData, 0);
            cipherMode.DoFinal(cipherTextData, length1);


            return cipherTextData;
        }
        catch (Exception ex)
        {
            // 处理加密过程中发生的异常  
            throw new CryptographicException("Encryption failed.", ex);
        }
    }


    /// <summary>  
    /// 使用SM4算法对指定密文进行解密。  
    /// </summary>  
    /// <param name="encryptMsg">待解密的密文（字节数组形式）。</param>  
    /// <param name="key">用于解密的密钥（字节数组形式）。</param>  
    /// <param name="iv">初始化向量（字节数组形式），对于ECB模式可以传递null。</param>  
    /// <param name="mode">加密模式，用于确定解密时使用的模式，默认为"ECB"。</param>  
    /// <returns>解密后的明文（字节数组形式）。</returns>  
    /// <exception cref="ArgumentNullException">当key或encryptMsg为空时抛出。</exception>  
    /// <exception cref="ArgumentException">当mode不被支持或iv对于非ECB模式为空时抛出。</exception>  
    /// <exception cref="CryptographicException">当解密过程中发生错误时抛出。</exception>  
    public static byte[] Decrypt(byte[] cipherTextData, byte[] key, byte[] iv, string mode = "ECB")
    {
        // 验证输入参数  
        if (cipherTextData==null||cipherTextData.Length==0)
            throw new ArgumentNullException(nameof(cipherTextData), "cipherTextData cannot be null or empty.");
        if (key == null || key.Length == 0)
            throw new ArgumentNullException(nameof(key), "Key cannot be null or empty.");
        if (iv == null && mode != "ECB")
            throw new ArgumentNullException(nameof(iv), "IV is required for modes other than ECB.");


        var cipher = new SM4Engine();
        PaddedBufferedBlockCipher cipherMode;

        switch (mode)
        {
            case "ECB":
                cipherMode = new PaddedBufferedBlockCipher(new EcbBlockCipher(cipher), new Pkcs7Padding());
                break;
            case "CBC":
                cipherMode = new PaddedBufferedBlockCipher(new CbcBlockCipher(cipher), new Pkcs7Padding());
                break;
            // ... [其他模式的情况] ...  
            default:
                throw new ArgumentException("Unsupported mode: " + mode);
        }

        // 创建密钥参数  
        KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", key);
        ICipherParameters parameters = mode == "ECB" ? keyParam : new ParametersWithIV(keyParam, iv);

        // 初始化解密器  
        cipherMode.Init(false, parameters);

        // 准备输出缓冲区  
        byte[] decryptedData = new byte[cipherMode.GetOutputSize(cipherTextData.Length)];

        try
        {
            // 执行解密操作  
            int length1 = cipherMode.ProcessBytes(cipherTextData, 0, cipherTextData.Length, decryptedData, 0);
            cipherMode.DoFinal(decryptedData, length1);

            return decryptedData;
        }
        catch (Exception ex)
        {
            // 处理解密过程中发生的异常  
            throw new CryptographicException("Decryption failed.", ex);
        }
    }
}
