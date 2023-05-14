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
    public class TicketCounterService
    {
        public static List<TicketCounterDTO> Get()
        {
            var data = DataAccessFactory.TicketCounterDataAccess().Get();
            var cfg = new MapperConfiguration(c => { c.CreateMap<TicketCounter, TicketCounterDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<TicketCounterDTO>>(data);
        }
        public static TicketCounterDTO Get(int id)
        {
            var data = DataAccessFactory.TicketCounterDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<TicketCounter, TicketCounterDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<TicketCounterDTO>(data);
        }
        public static TicketCounterDTO Add(TicketCounterDTO ticket)
        {
            var cfg = new MapperConfiguration(c => { c.CreateMap<TicketCounter, TicketCounterDTO>(); c.CreateMap<TicketCounterDTO, TicketCounter>(); });
            var mapper = new Mapper(cfg);
            var am = mapper.Map<TicketCounter>(ticket);
            var data = DataAccessFactory.TicketCounterDataAccess().Add(am);
            if (data != null) return mapper.Map<TicketCounterDTO>(data);
            return null;
        }


        public static TicketCounterDTO Delete(int id)
        {
            var data = DataAccessFactory.TicketCounterDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<TicketCounter, TicketCounterDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<TicketCounterDTO>(data);
        }
        public static TicketCounterDTO Update(TicketCounterDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TicketCounterDTO, TicketCounter>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(dto);
            DataAccessFactory.UserDataAccess().Update(data);
            return mapper.Map<TicketCounterDTO>(data);
        }
    }
}
