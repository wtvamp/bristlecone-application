using AutoMapper;
using Bristlecone.DataAccessLayer.Entities;
using Bristlecone.ViewModels.DTO;
using System.Collections.Generic;

namespace Bristlecone.ServiceLayer.Common
{
    public static class AutoMapperInitialization
    {
        public static void InitializeMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Application, ApplicationDTO>();
                cfg.CreateMap<ApplicationDTO, Application>();
                cfg.CreateMap<List<Application>, List<ApplicationDTO>>();
                cfg.CreateMap<List<ApplicationDTO>, List<Application>>();
                cfg.CreateMap<NewApplicationDTO, ApplicationDTO>();
                cfg.CreateMap<ApplicationDTO, NewApplicationDTO>();
            });
        }
    }
}
