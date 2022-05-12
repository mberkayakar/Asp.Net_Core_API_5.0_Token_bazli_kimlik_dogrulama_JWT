using AKAR.AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.Services
{
    public interface IUserInterface
    {
        Task<Response<UserAppDTO>> CreateUserASYNC(CreateUserDTO userDTO);
        Task<Response<UserAppDTO>> CreateByUserNameASYNC(string username);

    }
}
