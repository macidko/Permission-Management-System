using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class UserManager : IUserService
{

    //Temeller

    IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public void Add(User user)
    {
        //Kontrolsüz; _userRepository.Add(user);

        //Kontrollü;
        if(user == null)
        {
            throw new Exception("Kullanıcı boş olamaz");
        }

        _userRepository.Add(user);
    }

    public void Delete(int id)
    {
        User userToDelete = _userRepository.GetById(id);

        if(userToDelete == null)
        {
            throw new Exception("Silinecek kullanıcı bulanamadı");
        }

        _userRepository.Delete(userToDelete);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User GetById(int id)
    {
        return _userRepository.GetById(id);
    }

    public void Update(User user)
    {
        User userToUpdate = _userRepository.GetById(user.Id);
        if(userToUpdate == null)
        {
            throw new Exception("Güncellenecek kullanıcı bulunamadı");
        }

        _userRepository.Update(userToUpdate);
    }
}
