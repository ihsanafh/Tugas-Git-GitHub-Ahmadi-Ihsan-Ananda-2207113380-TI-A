<template>
  <div id="app">
    <img src="./assets/logo-unri2.png" height="75" width=""/>
    <web-toolbar></web-toolbar>
    <router-view/>
    <web-home>
      <web-login></web-login>
    </web-home>
    <web-footer></web-footer>
  </div>
</template>

<script>
import WebFooter from '@/components/WebFooter.vue'
import WebToolbar from '@/components/WebToolbar.vue'
import WebHome from '@/components/WebHome.vue'
import WebLogin from '@/components/WebLogin.vue'

export default {
  name: 'App',
  components: {WebFooter, WebToolbar, WebHome, WebLogin}
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
}
</style>
