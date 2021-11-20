using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikDogrula(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.BirthYear);
        }
    }
}
