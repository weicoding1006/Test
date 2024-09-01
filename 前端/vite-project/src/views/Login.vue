<template>
    <main class="h-screen flex items-center justify-center">
        <div class="border border-black w-1/2 p-3">
            <h1 class="text-3xl">登入</h1>
            <input v-model="account" type="text" class="border border-black w-full p-2 my-2" placeholder="請輸入帳號">
            <input v-model="password" type="password" class="border border-black w-full p-2 my-2" placeholder="請輸入密碼">
            <div class="flex gap-3 items-center my-2">
                <button  @click="login" class="bg-blue-600 text-white py-1 px-3 rounded">登入</button>
                <router-link class="bg-gray-600 text-white py-1 px-3 rounded" to="/register">註冊</router-link>
            </div>
        </div>
    </main>
</template>

<script setup lang="ts">
import { onMounted, ref } from "vue";
import axios from 'axios';
import {useRouter} from 'vue-router'
const account = ref<string>('');
const password = ref<string>('');
const router = useRouter()
async function login() {
    if (!account.value || !password.value) {
        alert('請填寫帳號和密碼');
        return;
    }
    const data = {
        account: account.value,
        password: password.value
    }
    try {
        const res = await axios.post('https://localhost:7253/api/Login', data)
        const { token } = res.data
        alert("登入成功")
        localStorage.setItem('token', token)
        router.push('/')
    } catch (err) {
        console.log(err);
    }
}
</script>