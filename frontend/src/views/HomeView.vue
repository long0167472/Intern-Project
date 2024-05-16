<template>
  <div>Đây là trang home</div>
</template>

<script>
import { mapGetters } from "vuex";

export default {
  computed: {
    ...mapGetters("auth", ["isAuthenticated", "user"]),
  },

  created() {
    if (!this.isAuthenticated) {
      this.$router.push({ name: "login" });
    }
  },
};
</script>
