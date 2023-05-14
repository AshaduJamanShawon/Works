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
    public class EmployeeServices
    {

        public static List<EmployeeDTO> Get()
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<EmployeeDTO>>(data);
        }

        public static List<EmployeeDTO> Get(int Id)
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<EmployeeDTO>>(data);
        }



        public static EmployeeDTO Add(EmployeeDTO employee)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDTO>();
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(cfg);
            var bo = mapper.Map<Employee>(employee);
            var data = DataAccessFactory.EmployeeDataAccess().Add(bo);

            if (data != null) return mapper.Map<EmployeeDTO>(data);
            return null;
        }


        public static EmployeeDTO Delete(int id)
        {
            var data = DataAccessFactory.EmployeeDataAccess().Delete(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<Employee, EmployeeDTO>(); });
            var mapper = new Mapper(cfg);
            return mapper.Map<EmployeeDTO>(data);
        }


        public static EmployeeDTO Update(EmployeeDTO dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(dto);
            DataAccessFactory.EmployeeDataAccess().Update(data);
            return mapper.Map<EmployeeDTO>(data);
        }

    }
}
