import Vue from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';
import filters from "./filters";
import callHubPlugin from './callHubPlugin';

vue.use(callHubPlugin);
Vue.config.productionTip = false;
filters();

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
