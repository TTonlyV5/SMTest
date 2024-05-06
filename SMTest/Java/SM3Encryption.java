import org.bouncycastle.crypto.digests.SM3Digest;
import org.bouncycastle.crypto.macs.HMac;
import org.bouncycastle.crypto.params.KeyParameter;

import cn.hutool.core.codec.Base64;
import cn.hutool.core.util.CharsetUtil;
import cn.hutool.core.util.HexUtil;

public class SM3Encryption {
    
        /**
     * 计算给定数据的SM3哈希值。
     * 
     * @param data 待处理的原始数据
     * @return SM3哈希的二进制结果
     */
    private static byte[] computeSm3Hash(String data) {
        byte[] dataBytes = data.getBytes(CharsetUtil.CHARSET_UTF_8);
        SM3Digest digest = new SM3Digest();
        digest.update(dataBytes, 0, dataBytes.length);
        byte[] result = new byte[digest.getDigestSize()];
        digest.doFinal(result, 0);
        return result;
    }

    /**
     * 计算给定数据的SM3哈希值，并返回Base64编码结果。
     * 
     * @param data 待处理的原始数据
     * @return SM3哈希的Base64编码字符串
     */
    public static String computeSm3Base64(String data) {
        return Base64.encode(computeSm3Hash(data));
    }

    /**
     * 计算给定数据的SM3哈希值，并返回十六进制字符串。
     * 
     * @param data 待处理的原始数据
     * @return SM3哈希的十六进制字符串表示
     */
    public static String computeSm3Hex(String data) {
        return HexUtil.encodeHexStr(computeSm3Hash(data));
    }

    /**
     * 计算给定数据和密钥的HMAC-SM3值。
     * 
     * @param data 待处理的原始数据
     * @param key  HMAC密钥
     * @return HMAC-SM3的二进制结果
     */
    private static byte[] computeHmacSm3(String data, String key) {
        byte[] dataBytes = data.getBytes(CharsetUtil.CHARSET_UTF_8);
        byte[] keyBytes = key.getBytes(CharsetUtil.CHARSET_UTF_8);

        SM3Digest digest = new SM3Digest();
        HMac hmac = new HMac(digest);
        hmac.init(new KeyParameter(keyBytes));
        hmac.update(dataBytes, 0, dataBytes.length);
        byte[] hmacResult = new byte[hmac.getMacSize()];
        hmac.doFinal(hmacResult, 0);
        return hmacResult;
    }

    /**
     * 计算给定数据和密钥的HMAC-SM3值，并返回Base64编码结果。
     * 
     * @param data 待处理的原始数据
     * @param key  HMAC密钥
     * @return HMAC-SM3的Base64编码字符串
     */
    public static String computeHmacSm3Base64(String data, String key) {
        return Base64.encode(computeHmacSm3(data, key));
    }

    /**
     * 计算给定数据和密钥的HMAC-SM3值，并返回十六进制字符串。
     * 
     * @param data 待处理的原始数据
     * @param key  HMAC密钥
     * @return HMAC-SM3的十六进制字符串表示
     */
    public static String computeHmacSm3Hex(String data, String key) {
        return HexUtil.encodeHexStr(computeHmacSm3(data, key));
    }

    public static void main(String[] args) {
        String originTxt = "Hello, SM3 Encryption!";
        String key = "98C63180C3748ED2";

        System.out.println("原文: " + originTxt);

        System.out.println("SM3 Hash (Base64): " + computeSm3Base64(originTxt));
        System.out.println("SM3 Hash (Hex): " + computeSm3Hex(originTxt));

        System.out.println("HMAC-SM3 (Base64): " + computeHmacSm3Base64(originTxt, key));
        System.out.println("HMAC-SM3 (Hex): " + computeHmacSm3Hex(originTxt, key));
    }


}
