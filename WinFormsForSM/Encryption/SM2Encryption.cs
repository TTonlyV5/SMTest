using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

/// <summary>
/// 加密工具类，提供基于SM2算法的加密和解密功能。  
/// </summary>
public class SM2Encryption
{
    /// <summary>
    /// 获取SM2曲线参数
    /// </summary>
    private static readonly X9ECParameters CurveParams = ECNamedCurveTable.GetByName("sm2p256v1");
    /// <summary>
    /// 随机数
    /// </summary>
    private static readonly SecureRandom secureRandom = new SecureRandom();
    /// <summary>  
    /// 生成SM2密钥对，密钥对使用Base64编码或Hex进行编码  
    /// </summary>  
    /// <param name="privateKey">输出的私钥（Base64编码或Hex）</param>  
    /// <param name="publicKey">输出的公钥（Base64编码或Hex）</param>  
    public static void GenerateSM2KeyPair(out string privateKey, out string publicKey, bool isHex = false)
    {
        try
        {
            // 创建SM2密钥对生成器的参数  
            ECKeyGenerationParameters keyGenParams = new ECKeyGenerationParameters(new ECDomainParameters(CurveParams), secureRandom);

            // 创建并初始化SM2密钥对生成器  
            ECKeyPairGenerator generator = new ECKeyPairGenerator();
            generator.Init(keyGenParams);

            // 生成密钥对  
            AsymmetricCipherKeyPair keyPair = generator.GenerateKeyPair();

            // 获取私钥参数  
            ECPrivateKeyParameters privateKeyParams = (ECPrivateKeyParameters)keyPair.Private;
            // 获取公钥参数  
            ECPublicKeyParameters publicKeyParams = (ECPublicKeyParameters)keyPair.Public;
            if (!isHex)
            {
                // 私钥：将私钥值转换为无符号字节数组并编码为Base64字符串  
                privateKey = Base64.ToBase64String(privateKeyParams.D.ToByteArrayUnsigned());
                // 公钥：将公钥点编码为压缩格式（如果需要）并编码为Base64字符串  
                // 注意：SM2公钥通常使用未压缩格式，这里使用未压缩格式  
                publicKey = Base64.ToBase64String(publicKeyParams.Q.GetEncoded(false)); // false 表示未压缩格式  
            }
            else
            {
                // 私钥：将私钥值转换为无符号字节数组并编码为Hex字符串  
                privateKey = Hex.ToHexString(privateKeyParams.D.ToByteArrayUnsigned());
                // 公钥：将公钥点编码为压缩格式（如果需要）并编码为Hex字符串  
                // 注意：SM2公钥通常使用未压缩格式，这里使用未压缩格式  
                publicKey = Hex.ToHexString(publicKeyParams.Q.GetEncoded(false)); // false 表示未压缩格式  
            }
        }
        catch (Exception ex)
        {
            // 处理异常，这里可以记录日志或抛出更具体的异常  
            throw new Exception("Error generating SM2 key pair.", ex);
        }
    }

    /// <summary>  
    /// SM2 公钥加密  
    /// </summary>  
    /// <param name="message">待加密的消息</param>  
    /// <param name="publicKey">SM2公钥（Base64编码）</param>  
    /// <returns>加密后的密文（Base64编码）</returns>  
    public static string EncryptBase64(string message, string publicKey)
    {
        try
        {
            byte[] encryptedData = Encrypt(Encoding.UTF8.GetBytes(message), Base64.Decode(publicKey));

            // 将加密结果转换为Base64字符串  
            return Base64.ToBase64String(encryptedData);
        }
        catch (Exception ex)
        {
            // 处理异常，例如公钥解码失败或加密操作出错  
            throw new Exception("Error encrypting message with SM2 public key.", ex);
        }
    }
    /// <summary>  
    /// SM2 公钥加密  
    /// </summary>  
    /// <param name="message">待加密的消息</param>  
    /// <param name="publicKey">SM2公钥（Hex编码）</param>  
    /// <returns>加密后的密文（Hex编码）</returns>  
    public static string EncryptHex(string message, string publicKey)
    {
        try
        {
            byte[] encryptedData = Encrypt(Encoding.UTF8.GetBytes(message), Hex.Decode(publicKey));

            // 将加密结果转换为Base64字符串  
            return Hex.ToHexString(encryptedData);
        }
        catch (Exception ex)
        {
            // 处理异常，例如公钥解码失败或加密操作出错  
            throw new Exception("Error encrypting message with SM2 public key.", ex);
        }
    }
    /// <summary>  
    /// SM2 公钥加密  
    /// </summary>  
    /// <param name="message">待加密的消息</param>  
    /// <param name="publicKey">SM2公钥（Base64编码）</param>  
    /// <returns>加密后的密文（Base64编码）</returns>  
    public static byte[] Encrypt(byte[] dataBytes, byte[] publicKey)
    {
        try
        {
            ECPoint q = CurveParams.Curve.DecodePoint(publicKey);
            //创建公钥参数
            ECDomainParameters domainParams = new ECDomainParameters(CurveParams);
            ECPublicKeyParameters pubKeyParams = new ECPublicKeyParameters("EC", q, domainParams);

            // 创建SM2加密引擎并初始化  
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(true, new ParametersWithRandom(pubKeyParams, secureRandom));


            // 执行加密操作  
            // 注意：SM2加密通常用于加密固定长度的数据块（例如ECCiphertext），这里我们假设消息长度适合直接加密  
            byte[] encryptedData = sm2Engine.ProcessBlock(dataBytes, 0, dataBytes.Length);

            return encryptedData;
        }
        catch (Exception ex)
        {
            // 处理异常，例如公钥解码失败或加密操作出错  
            throw new Exception("Error encrypting message with SM2 public key.", ex);
        }
    }
    /// <summary>  
    /// 使用SM2私钥解密消息  
    /// </summary>  
    /// <param name="ciphertext">待解密的密文（Base64编码）</param>  
    /// <param name="privateKey">SM2私钥（Base64编码）</param>  
    /// <returns>解密后的明文</returns>  
    public static string DecryptBase64(string ciphertext, string privateKey)
    {
        try
        {
            // 执行解密操作  
            byte[] decryptedData = Decrypt(Base64.Decode(ciphertext), Base64.Decode(privateKey));

            // 将解密结果转换为字符串  
            return Encoding.UTF8.GetString(decryptedData);
        }
        catch (Exception ex)
        {
            // 处理异常，例如私钥解码失败、密文解码失败或解密操作出错  
            throw new Exception("Error decrypting ciphertext with SM2 private key.", ex);
        }
    }
    /// <summary>  
    /// 使用SM2私钥解密消息  
    /// </summary>  
    /// <param name="ciphertext">待解密的密文（Hex编码）</param>  
    /// <param name="privateKey">SM2私钥（Hex编码）</param>  
    /// <returns>解密后的明文</returns>  
    public static string DecryptHex(string ciphertext, string privateKey)
    {
        try
        {
            // 执行解密操作  
            byte[] decryptedData = Decrypt(Hex.Decode(ciphertext), Hex.Decode(privateKey));

            // 将解密结果转换为字符串  
            return Encoding.UTF8.GetString(decryptedData);
        }
        catch (Exception ex)
        {
            // 处理异常，例如私钥解码失败、密文解码失败或解密操作出错  
            throw new Exception("Error decrypting ciphertext with SM2 private key.", ex);
        }
    }
    /// <summary>  
    /// 使用SM2私钥解密消息  
    /// </summary>  
    /// <param name="encryptedData">待解密的密文（字节数组形式）</param>  
    /// <param name="privateKey">SM2私钥（字节数组形式）</param>  
    /// <returns>解密后的明文（字节数组形式）</returns>  
    public static byte[] Decrypt(byte[] encryptedData, byte[] privateKey)
    {
        try
        {
            // 解码私钥  
            BigInteger d = new BigInteger(1, privateKey);

            // 获取SM2曲线参数  
            ECDomainParameters domainParams = new ECDomainParameters(CurveParams);

            // 创建私钥参数  
            ECPrivateKeyParameters privateKeyParams = new ECPrivateKeyParameters(d, domainParams);

            // 创建SM2解密引擎并初始化  
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(false, privateKeyParams);

            // 执行解密操作  
            byte[] decryptedData = sm2Engine.ProcessBlock(encryptedData, 0, encryptedData.Length);

            // 将解密结果转换为字符串  
            return decryptedData;
        }
        catch (Exception ex)
        {
            // 处理异常，例如私钥解码失败、密文解码失败或解密操作出错  
            throw new Exception("Error decrypting ciphertext with SM2 private key.", ex);
        }
    }
}