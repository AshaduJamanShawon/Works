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
    public class BusOwnerService
    {
        public static List<BusOwnerDTO> Get()
        {
            var data = DataAccessFactory.BusOwnerDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusOwner, BusOwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<BusOwnerDTO>>(data);
        }

        public static List<BusOwnerDTO> Get(int Id)
        {
            var data = DataAccessFactory.BusOwnerDataAccess().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusOwner, BusOwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<BusOwnerDTO>>(data);
        }



        public static BusOwnerDTO Add(BusOwnerDTO busOwners)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BusOwner, BusOwnerDTO>();
                c.CreateMap<BusOwnerDTO, BusOwner>();
            });
            var mapper = new Mapper(cfg);
            var bo = mapper.Map<BusOwner>(busOwners);
            var data = DataAccessFactory.BusOwnerDataAccess().Add(bo);

            if (data != null) return mapper.Map<BusOwnerDTO>(data);
            return null;
        }


        public static BusOwnerDTO Delete(int id)
        {
            var data = DataAccessFactory.BusOwnerDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<BusOwner, BusOwnerDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<BusOwnerDTO>(data);
        }
        public static BusOwnerDTO Update(BusOwnerDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusOwnerDTO, BusOwner>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusOwner>(dto);
            DataAccessFactory.BusOwnerDataAccess().Update(data);
            return mapper.Map<BusOwnerDTO>(data);
        }

    }
}
