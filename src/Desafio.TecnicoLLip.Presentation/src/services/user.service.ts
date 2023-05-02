import axios from 'axios';
import authHeader from './auth-header';
import authService from './auth.service';
const API_URL = 'https://localhost:5001/api/';

class UserService {

  getPublicContent() {
    return axios.get(API_URL + 'all');
  }

  getUserBoard() {
    return axios.get(API_URL + 'user', { headers: authHeader() });
  }

  getModeratorBoard() {
    return axios.get(API_URL + 'mod', { headers: authHeader() });
  }

  getAdminBoard() {
    return axios.get(API_URL + 'admin', { headers: authHeader() });
  }

    register(username: string, email: string, password: string) {

    var user = authService.getCurrentUser();

    let config = {
        headers: {
            'Authorization': 'Bearer ' + user.accessToken
        }
    };

    return axios.post(API_URL + "Usuarios/v1", {
        name: username,
        email: email,
        password: password
    }, config);
  }
}

export default new UserService();
