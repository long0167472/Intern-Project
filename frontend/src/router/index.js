import { createRouter, createWebHistory } from "vue-router";
import Login_Logout from "../views/Login_Logout.vue";

const routes = [
  {
    path: "/",
    name: "login_logout",
    component: Login_Logout,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
