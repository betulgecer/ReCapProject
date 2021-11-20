using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        bool IUserValidationService.Validate(User user)
        {
            if (user.BirthYear == 1998 && user.FirstName == "Betül" && user.LastName == "Geçer" && user.NationalityId == "42517863259")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    }
