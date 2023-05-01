import axios from "axios";
import api from './api.service';

const API_URL = "https://localhost:5001/api/";

let headers: {
    "Content-Type": "application/json",
    'Access-Control-Allow-Origin': '*',
};

class AuthService {
      
    login(email: string, password: string) {
        return axios(API_URL + "Logins", {
            method: 'POST',
            data: { email: email, senha: password },
            headers: {
                'Accept' : 'text/ plain',
                'Content-Type': 'application/ json - patch + json'
            }
        })
        .then(response => {
            if (response.data.accessToken) {
                localStorage.setItem("token", JSON.stringify(response.data));
            }
            return response.data;
        })
        .catch((err) => {
            console.error("ops! ocorreu um erro" + err);
        });            ;
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
}

export default new AuthService();
