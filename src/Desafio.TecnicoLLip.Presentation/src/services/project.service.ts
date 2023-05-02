import axios from 'axios';
import authService from './auth.service';
const API_URL = 'https://localhost:5001/api/';

class ProjectService {
 register(id: number, titulo: string, descricao: string, datacriacao: Date) {

    var user = authService.getCurrentUser();

    let config = {
        headers: {
            'Authorization': 'Bearer ' + user.accessToken
        }
    };

    return axios.post(API_URL + "Projetos/v1", {
        titulo: titulo,
        descricao: descricao,
        datacriacao: datacriacao
    }, config)
    .then(response => {
        if (response.data.accessToken) {
            localStorage.setItem("token", JSON.stringify(response.data));
        }
        return response.data;
    })
    .catch((err) => {
       console.error("ops! ocorreu um erro" + err);
    }); 
  }
}

export default new ProjectService();
