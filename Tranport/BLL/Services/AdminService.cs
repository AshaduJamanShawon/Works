using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO>Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var cfg = new MapperConfiguration(c => { c.CreateMap<Admin, AdminDTO>(); });
            var mapper=new Mapper(cfg);
            return mapper.Map<List<AdminDTO>>(data);    
        }
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<Admin, AdminDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);
        }
        public static AdminDTO Add(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c => { c.CreateMap<Admin, AdminDTO>(); c.CreateMap<AdminDTO, Admin>(); });
            var mapper = new Mapper(cfg);
            var am=mapper.Map<Admin>(admin); 
            var data = DataAccessFactory.AdminDataAccess().Add(am);
            if(data!=null)return mapper.Map<AdminDTO>(data);
            return null;    
        }
        

        public static AdminDTO Delete(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<Admin, AdminDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);
        }
        public static AdminDTO Update(AdminDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(dto);
            DataAccessFactory.AdminDataAccess().Update(data);
            return mapper.Map<AdminDTO>(data);
        }
    }
}
