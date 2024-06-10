import { userRegisterRequest } from "../models/userRegisterRequest";
import { BASE_API_URL } from "../core/environment/environment";
import { userLoginRequest } from "../models/userLoginRequest";
import axiosInstance from "../core/interceptors/axiosInterceptor";

class UserService {
    register(userData: userRegisterRequest) {
        return axiosInstance.post(BASE_API_URL + "Auth/Register", userData);
    }

    login(userData: userLoginRequest) {
        return axiosInstance.post(BASE_API_URL + "Auth/Login", userData);
    }
}

export default new UserService();