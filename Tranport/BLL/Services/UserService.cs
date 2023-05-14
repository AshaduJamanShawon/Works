using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var cfg = new MapperConfiguration(c => { c.CreateMap<User, UserDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<UserDTO>>(data);
        }
        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<User, UserDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<UserDTO>(data);
        }
        public static UserDTO Add(UserDTO user)
        {
            var cfg = new MapperConfiguration(c => { c.CreateMap<User, UserDTO>(); c.CreateMap<UserDTO, User>(); });
            var mapper = new Mapper(cfg);
            var am = mapper.Map<User>(user);
            var data = DataAccessFactory.UserDataAccess().Add(am);
            if (data != null) return mapper.Map<UserDTO>(data);
            return null;
        }


        public static UserDTO Delete(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<User, UserDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<UserDTO>(data);
        }
        public static UserDTO Update(UserDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(dto);
            DataAccessFactory.UserDataAccess().Update(data);
            return mapper.Map<UserDTO>(data);
        }
    }
}
