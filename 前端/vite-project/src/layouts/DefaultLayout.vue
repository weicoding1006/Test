<template>
    <header class="w-full bg-gray-300 py-2">
        <div class="container mx-auto flex items-center justify-between">
            <h1 class="text-3xl">Logo</h1>
            <nav>
                <ul class="flex gap-3">
                    <li><router-link to="/">首頁</router-link></li>
                    <li><button @click="logout">登出</button></li>
                </ul>
            </nav>
        </div>
    </header>
    <main class="container mx-auto py-2">
        <router-view></router-view>
    </main>
</template>


<script setup lang="ts">
import {useRouter} from 'vue-router'
const router = useRouter()
function logout() {
    const confirm = window.confirm('確定要登出嗎?')
    if(!confirm) return
    alert('登出成功')
    localStorage.removeItem('token')
    router.push('/login')
}
</script>