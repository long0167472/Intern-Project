<template>
  <v-container>
    <v-row align="center" justify="center">
      <v-col cols="12" sm="10">
        <v-card class="elevation-3 mt-10">
          <v-window v-model="step">
            <v-window-item :value="1">
              <v-row>
                <v-col cols="12" md="6">
                  <v-card-text class="mt-12">
                    <h4 class="text-center">Login in to Your Account</h4>
                    <v-row align="center" justify="center">
                      <v-col cols="12" sm="8">
                        <v-text-field
                          v-model="email"
                          label="Email"
                          outlined
                          dense
                          class="mt-5"
                          bg-color="white"
                          color="blue"
                          :rules="emailRules"
                        >
                        </v-text-field>

                        <v-text-field
                          label="Password"
                          outlined
                          dense
                          bg-color="white"
                          color="blue"
                          autocomplete="false"
                          :type="showPassword ? 'text' : 'password'"
                          :rules="rulesPassWork"
                          :append-icon="
                            showPassword ? 'mdi-eye' : 'mdi-eye-off'
                          "
                          @click:append="showPassword = !showPassword"
                        ></v-text-field>
                        <div
                          class="d-flex justify-space-between"
                          style="height: 54px"
                        >
                          <v-checkbox v-model="checked" color="info">
                            <template #label>
                              <span
                                style="
                                  font-size: 13px;
                                  color: black;
                                  font-weight: 700;
                                "
                              >
                                Memorize
                              </span>
                            </template>
                          </v-checkbox>

                          <p
                            class="mt-5"
                            style="
                              font-size: 12px;
                              font-weight: 700;
                              color: blue;
                            "
                          >
                            Forgot password ?
                          </p>
                        </div>
                        <v-btn rounded color="blue" dark block tile
                          >Log in</v-btn
                        >

                        <h5 class="text-center grey-text mt-4 mb-3">
                          Or Log in using
                        </h5>
                        <div class="d-flex justify-center mb-6">
                          <v-btn
                            depressed
                            outlined
                            color="gray"
                            @click="loginWithGoogle"
                            class="mx-3 btn"
                          >
                            <v-icon color="red" size="30">mdi-google</v-icon>
                          </v-btn>
                          <v-btn
                            depressed
                            outlined
                            color="gray"
                            @click="loginWithFacebook"
                            class="btn"
                          >
                            <v-icon color="blue" size="30">mdi-facebook</v-icon>
                          </v-btn>
                        </div>
                      </v-col>
                    </v-row>
                  </v-card-text>
                </v-col>
                <v-col cols="12" md="6" class="custom-blue-bg rounded-bl-xl">
                  <div style="text-align: center; padding: 180px 0">
                    <v-card-text class="white-text">
                      <h3 class="text-center">Don't Have an Account Yet?</h3>
                    </v-card-text>
                    <div class="text-center">
                      <v-btn rounded tile outlined dark @click="step++"
                        >SIGN UP</v-btn
                      >
                    </div>
                  </div>
                </v-col>
              </v-row>
            </v-window-item>
            <v-window-item :value="2">
              <v-row>
                <v-col cols="12" md="6" class="custom-blue-bg rounded-br-xl">
                  <div style="text-align: center; padding: 180px 0">
                    <v-card-text class="white-text">
                      <h3 class="text-center">Alredy Signed up?</h3>
                    </v-card-text>
                    <div class="text-center">
                      <v-btn rounded tile outlined dark @click="step--"
                        >Log in</v-btn
                      >
                    </div>
                  </div>
                </v-col>

                <v-col cols="12" md="6">
                  <v-card-text class="mt-12">
                    <h4 class="text-center">Sign Up for an Account</h4>
                    <v-row align="center" justify="center">
                      <v-col cols="12" sm="8">
                        <v-row>
                          <v-col cols="12" sm="6">
                            <v-text-field
                              v-model="firtName"
                              label="First Name"
                              outlined
                              bg-color="white"
                              dense
                              color="blue"
                              autocomplete="false"
                              class="mt-4"
                              :rules="rulesFirt"
                            />
                          </v-col>
                          <v-col cols="12" sm="6">
                            <v-text-field
                              v-model="lastName"
                              label="Last Name"
                              outlined
                              bg-color="white"
                              dense
                              color="blue"
                              autocomplete="false"
                              class="mt-4"
                              :rules="rulesLast"
                            />
                          </v-col>
                        </v-row>
                        <v-text-field
                          v-model="email"
                          label="Email"
                          bg-color="white"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          :rules="emailRules"
                        />
                        <v-text-field
                          label="Password"
                          outlined
                          dense
                          bg-color="white"
                          color="blue"
                          autocomplete="false"
                          :type="showPassword ? 'text' : 'password'"
                          :rules="rulesPassWork"
                          :append-icon="
                            showPassword ? 'mdi-eye' : 'mdi-eye-off'
                          "
                          @click:append="showPassword = !showPassword"
                        ></v-text-field>

                        <v-btn rounded color="blue" dark block tile
                          >Sign up</v-btn
                        >

                        <h5 class="text-center grey-text mt-4 mb-3">
                          Or Sign up using
                        </h5>
                        <div class="d-flex justify-center mb-6">
                          <v-btn
                            depressed
                            outlined
                            color="gray"
                            @click="loginWithGoogle"
                            class="mx-3 btn"
                          >
                            <v-icon color="red" size="30">mdi-google</v-icon>
                          </v-btn>
                          <v-btn
                            depressed
                            outlined
                            color="gray"
                            @click="loginWithFacebook"
                            class="btn"
                          >
                            <v-icon color="blue" size="30">mdi-facebook</v-icon>
                          </v-btn>
                        </div>
                      </v-col>
                    </v-row>
                  </v-card-text>
                </v-col>
              </v-row>
            </v-window-item>
          </v-window>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  data: () => ({
    step: 1,
    passwork: "",
    showPassword: false,
    checked: false,
    rulesPassWork: [
      (v) => !!v || "Mật khẩu không được để trống",
      (v) => v.length > 6 || "Mật khẩu không được ít hơn 6 ký tự",
    ],
    email: "",
    emailRules: [
      (v) => !!v || "E-mail là bắt buộc",
      (v) => /.+@.+\..+/.test(v) || "E-mail phải hợp lệ",
    ],
    firtName: "",
    rulesFirt: [
      (v) => !!v || "Firtname không được bỏ trống",
      (v) => v.length < 2 || "Firtname không được ít hơn 2 ký tự",
    ],
    lastName: "",
    rulesLast: [
      (v) => !!v || "Lastname  không được bỏ trống",
      (v) => v.length < 2 || "Lastname không được ít hơn 2 ký tự",
    ],
  }),
  methods: {
    loginWithGoogle() {
      window.location.href = "https://accounts.google.com/ServiceLogin";
    },
    loginWithFacebook() {
      window.location.href = "https://www.facebook.com/login";
    },
  },
};
</script>
<style scoped>
.v-application .rounded-bl-xl {
  border-bottom-left-radius: 300px;
}
.v-application .rounded-br-xl {
  border-bottom-right-radius: 300px;
}
.custom-blue-bg {
  background-color: #009fd9;
}
.btn:hover {
  transform: scale(1.15);
}
</style>
