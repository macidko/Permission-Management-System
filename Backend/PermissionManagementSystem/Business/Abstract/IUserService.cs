using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Features.Users.Dtos;
using Entities.Concrete;


namespace Business.Abstract;

public interface IUserService
{
    //    1. Yetki Atama:
    //• Yetkilendirilmiş kullanıcılar, diğer kullanıcılara yetki atayabilmelidir.
    //• Yetki atama işlemi, kullanıcı adı veya kimliği ve yetki adı kullanılarak
    //gerçekleştirilebilir.

    //AddPermissionByUserId(int userId, string permission);
    //AddPermissionByUsername(string username, string permission);


    //2. Yetki Kaldırma:
    //• Yetkilendirilmiş kullanıcılar, diğer kullanıcılardan yetki kaldırabilmelidir.
    //• Yetki kaldırma işlemi, kullanıcı adı veya kimliği ve yetki adı kullanılarak
    //gerçekleştirilebilir.

    //DeletePermissionByUserId(int userId, string permission);
    //DeletePermissionByUsername(string username, string permission);


    //3. Yetki Kontrolü:
    //• Sistem, herhangi bir işlem gerçekleştirilmeden önce kullanıcının ilgili yetkiye
    //sahip olup olmadığını kontrol etmelidir.

    //Methodların içerisinde kontrol edilecek (Manager??)

    //Task Add(AddUserRequest dto);
    //void Update(User user);
    //void Delete(int id);
    //User GetById(int id);
    //Task<List<ListUserResponse>> GetAll();
}
