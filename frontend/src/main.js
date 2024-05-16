import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import vuetify from "./plugins/vuetify";
import { loadFonts } from "./plugins/webfontloader";
import vue3GoogleLogin from "vue3-google-login";
import axios from "axios";

window.axios = axios;
loadFonts();
const app = createApp(App);

app
  .use(router)
  .use(store)
  .use(vuetify)
  .use(vue3GoogleLogin, {
    clientId:
      "720188747692-r5a785i2ai3kd3v7jsfrdh4drmnh8ul5.apps.googleusercontent.com",
  })
  .mount("#app");
