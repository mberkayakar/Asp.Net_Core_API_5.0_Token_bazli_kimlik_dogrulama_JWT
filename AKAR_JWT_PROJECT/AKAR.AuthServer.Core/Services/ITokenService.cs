using AKAR.AuthServer.Core.DTOs;
using AKAR.AuthServer.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userapp);

        ClientDTO CreateTokenByClient(ClientDTO client);
    }
}
