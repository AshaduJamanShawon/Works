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
    public class DriverServices
    {

        public static List<DriverDTO> Get()
        {
            var data = DataAccessFactory.DriverDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<DriverDTO>>(data);
        }

        public static List<DriverDTO> Get(int Id)
        {
            var data = DataAccessFactory.DriverDataAccess().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<DriverDTO>>(data);
        }



        public static DriverDTO Add(DriverDTO driver)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
                c.CreateMap<DriverDTO, Driver>();
            });
            var mapper = new Mapper(cfg);
            var bo = mapper.Map<Driver>(driver);
            var data = DataAccessFactory.DriverDataAccess().Add(bo);

            if (data != null) return mapper.Map<DriverDTO>(data);
            return null;
        }

        public static DriverDTO Delete(int id)
        {
            var data = DataAccessFactory.DriverDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap< Driver, DriverDTO >(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<DriverDTO>(data);
        }
        public static DriverDTO Update(DriverDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<DriverDTO, Driver>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Driver>(dto);
            DataAccessFactory.DriverDataAccess().Update(data);
            return mapper.Map<DriverDTO>(data);
        }

    }
}
