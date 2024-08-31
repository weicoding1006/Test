import { createRouter, createWebHistory } from 'vue-router';

const routes = [
  {
    path: '/',
    component: () => import('@/layouts/DefaultLayout.vue'),
    children:[
      {
        path:'',
        name:'Index',
        component:() => import('@/views/Index.vue')
      }
    ]
  },
  {
    path:'/login',
    name:'Login',
    component:() => import('@/views/Login.vue')
  },
  {
    path:'/register',
    name:'Register',
    component:() => import('@/views/Register.vue')
  }
];

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
});

export default router;
