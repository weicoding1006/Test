<template>
    <main class="h-screen flex items-center justify-center">
        <div class="border border-black w-1/2 p-3">
            <h1 class="text-3xl">登入</h1>
            <input type="text" class="border border-black w-full p-2 my-2" placeholder="請輸入帳號">
            <input type="password" class="border border-black w-full p-2 my-2" placeholder="請輸入密碼">
            <div class="flex gap-3 items-center my-2">
                <button class="bg-blue-600 text-white py-1 px-3 rounded">登入</button>
                <router-link class="bg-gray-600 text-white py-1 px-3 rounded" to="/register">註冊</router-link>
            </div>

        </div>

    </main>
</template>