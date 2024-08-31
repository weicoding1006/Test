<template>
    <div>
        <p>Count: {{ store.count }}</p>
        <button @click="store.increment">增加</button>
    </div>
</template>

<script setup lang="ts">
import { useCounterStore } from '../stores/useCounterStore';
import { onMounted } from 'vue';
const store = useCounterStore();
onMounted(() => {

});


</script>