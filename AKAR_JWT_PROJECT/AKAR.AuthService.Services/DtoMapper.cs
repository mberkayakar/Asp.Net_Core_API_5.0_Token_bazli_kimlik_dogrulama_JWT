using AKAR.AuthServer.Core.DTOs;
using AKAR.AuthServer.EntityLayer;
using AKAR.AuthServer.EntityLayer.Concrete;
using AutoMapper;
using System;

namespace AKAR.AuthService.Services
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            // 10.00 
            // reverse map product tan dto ya dto dan ise prdouct a dönebilir manasına gelmektedir.    
            CreateMap<ProductDTO,Product>().ReverseMap();
            CreateMap<UserAppDTO, UserApp>().ReverseMap();

        }

    }
}
