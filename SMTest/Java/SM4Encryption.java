import cn.hutool.core.codec.Base64;
import cn.hutool.core.util.CharsetUtil;
import cn.hutool.core.util.HexUtil;
import cn.hutool.crypto.Mode;
import cn.hutool.crypto.Padding;
import cn.hutool.crypto.symmetric.SM4;
import cn.hutool.crypto.symmetric.SymmetricCrypto;

public class SM4Encryption {

    // 加密为Base64
    public static String encryptToBase64(String plainTxt, Mode mode, String key, String iv) {
        return encrypt(plainTxt, mode, key, iv, true);
    }

    // 加密为Hex
    public static String encryptToHex(String plainTxt, Mode mode, String key, String iv) {
        return encrypt(plainTxt, mode, key, iv, false);
    }

    // 解密Base64
    public static String decryptFromBase64(String cipherTxt, Mode mode, String key, String iv) {
        return decrypt(cipherTxt, mode, key, iv, true);
    }

    // 解密Hex
    public static String decryptFromHex(String cipherTxt, Mode mode, String key, String iv) {
        return decrypt(cipherTxt, mode, key, iv, false);
    }

    private static String encrypt(String plainTxt, Mode mode, String key, String iv, boolean useBase64) {
        SymmetricCrypto sm4 = null;
        if (mode.equals(Mode.ECB)) {
            sm4 = new SM4(mode, Padding.PKCS5Padding, key.getBytes(CharsetUtil.CHARSET_UTF_8));
        } else if (mode.equals(Mode.CBC)) {
            sm4 = new SM4(mode, Padding.PKCS5Padding, key.getBytes(CharsetUtil.CHARSET_UTF_8),
                    iv.getBytes(CharsetUtil.CHARSET_UTF_8));
        }
        byte[] encrypBytes = sm4.encrypt(plainTxt);

        return useBase64 ? Base64.encode(encrypBytes) : HexUtil.encodeHexStr(encrypBytes);
    }

    private static String decrypt(String cipherTxt, Mode mode, String key, String iv, boolean isBase64) {
        SymmetricCrypto sm4 = null;
        if (mode.equals(Mode.ECB)) {
            sm4 = new SM4(mode, Padding.PKCS5Padding, key.getBytes(CharsetUtil.CHARSET_UTF_8));
        } else if (mode.equals(Mode.CBC)) {
            sm4 = new SM4(mode, Padding.PKCS5Padding, key.getBytes(CharsetUtil.CHARSET_UTF_8),
                    iv.getBytes(CharsetUtil.CHARSET_UTF_8));
        }

        byte[] cipherBytes = isBase64 ? Base64.decode(cipherTxt) : HexUtil.decodeHex(cipherTxt);
        return sm4.decryptStr(cipherBytes, CharsetUtil.CHARSET_UTF_8);
    }

    public static void main(String[] argc) {
        String originTxt = "Hello, SM4 Encryption!";
        String key = "98C63180C3748ED2";
        String iv = "UISwD9fW6cFh9SNS";
        Mode mode = Mode.CBC;
        System.out.println("原文: " + originTxt);
        String cipherTxt = encryptToBase64(originTxt, mode, key, iv);
        System.out.println("密文: " + cipherTxt);
        String plainTxt = decryptFromBase64(cipherTxt, mode, key, iv);
        System.out.println("解密结果: " + plainTxt);

        // 示例：加密为Hex
        String cipherTxtHex = encryptToHex(originTxt, mode, key, iv);
        System.out.println("Hex密文: " + cipherTxtHex);

        // 示例：从Hex解密
        String plainTxtFromHex = decryptFromHex(cipherTxtHex, mode, key, iv);
        System.out.println("解密结果(Hex): " + plainTxtFromHex);
    }
}
