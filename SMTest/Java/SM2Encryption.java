import java.math.BigInteger;
import java.security.SecureRandom;

import org.bouncycastle.asn1.x9.ECNamedCurveTable;
import org.bouncycastle.asn1.x9.X9ECParameters;
import org.bouncycastle.crypto.AsymmetricCipherKeyPair;
import org.bouncycastle.crypto.engines.SM2Engine;
import org.bouncycastle.crypto.generators.ECKeyPairGenerator;
import org.bouncycastle.crypto.params.ECDomainParameters;
import org.bouncycastle.crypto.params.ECKeyGenerationParameters;
import org.bouncycastle.crypto.params.ECPrivateKeyParameters;
import org.bouncycastle.crypto.params.ECPublicKeyParameters;
import org.bouncycastle.crypto.params.ParametersWithRandom;
import org.bouncycastle.math.ec.ECPoint;

import cn.hutool.core.codec.Base64;
import cn.hutool.core.util.StrUtil;

public class SM2Encryption {
    private static final X9ECParameters CurveParams = ECNamedCurveTable.getByName("sm2p256v1");
    private static final SecureRandom SECURE_RANDOM = new SecureRandom();

    public static void generateSM2KeyPair(StringBuilder privateKey, StringBuilder publicKey) {
        try {
            ECKeyGenerationParameters keyGenParams = new ECKeyGenerationParameters(
                    new ECDomainParameters(CurveParams),
                    SECURE_RANDOM);

            ECKeyPairGenerator generator = new ECKeyPairGenerator();
            generator.init(keyGenParams);

            AsymmetricCipherKeyPair keyPair = generator.generateKeyPair();

            ECPrivateKeyParameters privateKeyParams = (ECPrivateKeyParameters) keyPair.getPrivate();
            privateKey.append(Base64.encode(privateKeyParams.getD().toByteArray()));

            ECPublicKeyParameters publicKeyParams = (ECPublicKeyParameters) keyPair.getPublic();
            publicKey.append(Base64.encode(publicKeyParams.getQ().getEncoded(false)));
        } catch (Exception e) {
            throw new RuntimeException("Error generating SM2 key pair.", e);
        }
    }

    public static String encrypt(String message, String publicKeyStr) {
        try {
            byte[] publicKeyBytes = Base64.decode(publicKeyStr);
            ECPoint q = CurveParams.getCurve().decodePoint(publicKeyBytes);
            ECPublicKeyParameters pubKeyParams = new ECPublicKeyParameters(q, new ECDomainParameters(CurveParams));

            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.init(true, new ParametersWithRandom(pubKeyParams, SECURE_RANDOM));

            byte[] dataBytes = StrUtil.bytes(message, "UTF-8");

            byte[] encryptedData = sm2Engine.processBlock(dataBytes, 0, dataBytes.length);

            return Base64.encode(encryptedData);
        } catch (Exception e) {
            throw new RuntimeException("Error encrypting message with SM2 public key.", e);
        }
    }

    public static String decrypt(String ciphertext, String privateKeyStr) {
        try {
            byte[] privateKeyBytes = Base64.decode(privateKeyStr);
            BigInteger d = new BigInteger(1, privateKeyBytes);

            ECPrivateKeyParameters privateKeyParams = new ECPrivateKeyParameters(d,
                    new ECDomainParameters(CurveParams));

            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.init(false, privateKeyParams);

            byte[] encryptedData = Base64.decode(ciphertext);

            byte[] decryptedData = sm2Engine.processBlock(encryptedData, 0, encryptedData.length);

            return StrUtil.str(decryptedData, "UTF-8");
        } catch (Exception e) {
            throw new RuntimeException("Error decrypting ciphertext with SM2 private key.", e);
        }
    }

    public static void main(String[] args) {

        StringBuilder publicKey = new StringBuilder();
        StringBuilder privateKey = new StringBuilder();

        // 生成密钥对
        generateSM2KeyPair(privateKey, publicKey);

        // 待加密的原始消息
        String originalMessage = "Hello, SM2 Encryption!";

        // 使用公钥加密
        String encryptedMessage = SM2Encryption.encrypt(originalMessage, publicKey.toString());
        System.out.println("Encrypted Message: " + encryptedMessage);

        // 使用私钥解密
        String decryptedMessage = SM2Encryption.decrypt(encryptedMessage, privateKey.toString());
        System.out.println("Decrypted Message: " + decryptedMessage);

    }
}
