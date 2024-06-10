import toastr from 'toastr';
import axios from 'axios';
import { BASE_API_URL } from '../environment/environment';

const axiosInstance = axios.create({
    baseURL: BASE_API_URL,
})

axiosInstance.interceptors.request.use(
    request => {
        const token = localStorage.getItem("token");
        if (token) {
            request.headers.Authorization = `Bearer ${token}`;
        }
        return request;
    },
    error => {
        if (error.response && error.response.data && error.response.data.detail) {
            toastr.error(error.response.data.detail);
        } else {
            toastr.error("Bir hata oluştu");
        }
        return Promise.reject(error);
    }
)

axiosInstance.interceptors.response.use(
    response => {
        const token = response.data.token;
        localStorage.setItem("token", token);
        return response;
    },
    error => {
        if (error.response && error.response.data && error.response.data.detail) {
            toastr.error(error.response.data.detail);
        } else {
            toastr.error("Bir hata oluştu");
        }
        return Promise.reject(error);
    }
)

export default axiosInstance;
