using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.MapperConfig
{
    public class Config
    {
        public static IMapper CreateConfig()
        {
            var config = new AutoMapper.MapperConfiguration
          (cfg => cfg.AddProfile(new DomainToViewModelProfile()));

            return config.CreateMapper();
        }
    }
}
