using AKAR.AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDTO loginDTO);
         
        Task<Response<TokenDto>> CreateTokenByRefreshToken(string RefreshToken);
        Task<Response<NoDataDTO>> RevokeRefreshToken (string RefreshToken);

        Task<Response<ClientDTO>> RevokeRefreshToken(ClientDTO clientDTO);



    }
}
