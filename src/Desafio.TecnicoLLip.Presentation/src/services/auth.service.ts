import axios from "axios";

const API_URL = "https://localhost:5001/api/";

class AuthService {
  login(username: string, password: string) {
        return axios
            .post(API_URL + "Logins", { email: username, senha: password 
      })
      .then(response => {
          if (response.data.success) {
            localStorage.setItem("user", JSON.stringify(response.data.objecto));
        }
        return response.data;
      })
      .catch((e) => {
          console.error(e.message);
      });
  }

  logout() {
    localStorage.removeItem("user");
  }

  register(username: string, email: string, password: string) {
    return axios.post(API_URL + "signup", {
      username,
      email,
      password
    });
  }

  getCurrentUser() {
    const userStr = localStorage.getItem("user");
    if (userStr) return JSON.parse(userStr);

    return null;
  }

  getToken()
  {
    const userStr = localStorage.getItem("user");
    if (userStr) return JSON.parse(userStr);

    return null
  }
}

export default new AuthService();
