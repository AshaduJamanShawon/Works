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
    public class BusDetailsServices
    {
         
        public static List<BusDetailsDTO> Get()
        {
            var data = DataAccessFactory.BusDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusDetails, BusDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<BusDetailsDTO>>(data);
        }

        public static List<BusDetailsDTO> Get(int Id)
        {
            var data = DataAccessFactory.BusDataAccess().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusDetails, BusDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<BusDetailsDTO>>(data);
        }



        public static BusDetailsDTO Add(BusDetailsDTO busdetails)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusDetails, BusDetailsDTO>();
                c.CreateMap<BusDetailsDTO, BusDetails>();
            });
            var mapper = new Mapper(cfg);
            var bo = mapper.Map<BusDetails>(busdetails);
            var data = DataAccessFactory.BusDataAccess().Add(bo);

            if (data != null) return mapper.Map<BusDetailsDTO>(data);
            return null;
        }

        public static BusDetailsDTO Delete(int id)
        {
            var data = DataAccessFactory.BusDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<BusDetails, BusDetailsDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<BusDetailsDTO>(data);
        }
        public static BusDetailsDTO Update(BusDetailsDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusDetailsDTO, BusDetails>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map< BusDetails> (dto);
            DataAccessFactory.BusDataAccess().Update(data);
            return mapper.Map<BusDetailsDTO>(data);
        }
    }
}
