using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.EntityLayer.Concrete
{


    // tüm datalar IdentityUser kütüphanesinden property olarak oluşturulackatır. Bu sebepten ötürü
    // ilk etapta identity kütüphanesini kurduktan sonra userApp içerisinde eklenmesini istediğin
    // PRoperty ler varsa onları  USERAPP içine ekleyebilirsin.
    public class UserApp: IdentityUser 
    {
        public string City { get; set; }
    }
}
