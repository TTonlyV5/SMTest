<template>
  <div>
    <label>
      加密完成后，将加密后的串作为接口参数的值，用来测试
      {"username":"zjs","message":加密结果}
    </label>
  </div>
  <br />

  <div>
    <textarea v-model="msg" class="textarea" placeholder="输入加密内容"></textarea>
  </div>
  <div>
    <input id="btnEncrypt" type="button" value="加密" @click="encrypt" />
    <input id="btnDecrypted" type="button" value="解密" @click="decrypt" />
  </div>
  <div>
    <label>密钥(key)hex格式:</label>
    <input type="text" v-model="key" class="key" />
  </div>
  <div>
    <label>向量(iv)hex格式:</label>
    <input type="text" v-model="iv" class="iv" />
  </div>
  <div>
    <textarea
      id="txtResult"
      v-model="encryptedResult"
      placeholder="加密结果"
      class="textarea"
    ></textarea>
  </div>

  <div>
    <textarea
      id="txtDESResult"
      v-model="decryptedResult"
      placeholder="解密结果"
      class="textarea"
    ></textarea>
  </div>
</template>

<script setup lang="ts">
import { sm4 } from "sm-crypto-v2";
import { ref, Ref } from "vue";

// 定义消息和结果的类型
type MessageType = string;
type ResultType = string;

// 初始化响应式变量并添加类型注解
const msg: Ref<MessageType> = ref("Hello, SM4 Encryption!");
const key: Ref<string> = ref("7a736647796a444a3259584b38455066");
const iv: Ref<string> = ref("547a39414d6578354679757172317965");
const encryptedResult: Ref<ResultType> = ref("");
const decryptedResult: Ref<ResultType> = ref("");

// 假设这里实现了加密和解密的方法
function encrypt(): void {
  // 实现加密逻辑，并将结果赋值给encryptedResult
  if (msg.value == null || msg.value == "") return;
  const encryptData = sm4.encrypt(msg.value, key.value, { mode: "cbc", iv: iv.value });
  encryptedResult.value = encryptData.toString();
}

function decrypt(): void {
  // 实现解密逻辑，并将结果赋值给decryptedResult
  if (msg.value == null || msg.value == "") return;
  const dencryptData = sm4.decrypt(encryptedResult.value, key.value, { mode: "cbc", iv: iv.value });
  decryptedResult.value = dencryptData.toString();
}
</script>

<style scoped>
.read-the-docs {
  color: #888;
}
.textarea {
  width: 100%;
  height: 100px;
}
.key {
  width: 70%;
  height: 35px;
}
.iv {
  width: 70%;
  height: 35px;
}
</style>
