using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine("Kullanıcı eklendi:" + " " +user.FirstName + " " + user.LastName);
            }
            else
            {
                Console.WriteLine("Kayıt başarısız,kullanıcı eklenemedi.");
            }

        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı güncellendi:" + " " + user.FirstName + " " + user.LastName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi:" + " " + user.FirstName + " " + user.LastName );
        }

        
    }
}
