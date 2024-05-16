export default {
  namespaced: true,
  state: () => ({
    isAuthenticated: false,
    user: null,
    //user: { name: "Google User" },
  }),
  mutations: {
    login(state, user) {
      state.isAuthenticated = true;
      state.user = user;
    },
    logout(state) {
      state.isAuthenticated = false;
      state.user = null;
    },
  },
  getters: {
    isAuthenticated: (state) => state.isAuthenticated,
    user: (state) => state.user,
  },
};
