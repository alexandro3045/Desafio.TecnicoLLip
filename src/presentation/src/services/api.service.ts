import axios from "axios";

const api = axios.create({
    baseURL: "https://localhost:5001/api",
    
});

api.defaults.headers.post['Access-Control-Allow-Origin'] = '*';

export default api;