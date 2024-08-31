<template>
    <header class="w-full bg-gray-300 py-2">
        <div class="container mx-auto flex items-center justify-between">
            <h1 class="text-3xl">Logo</h1>
            <nav>
                <ul class="flex gap-3">
                    <li><router-link to="/">首頁</router-link></li>
                    <li><router-link to="/login">登入</router-link></li>
                </ul>
            </nav>
        </div>
    </header>
    <main class="container mx-auto py-2">
        <router-view></router-view>
    </main>
</template>