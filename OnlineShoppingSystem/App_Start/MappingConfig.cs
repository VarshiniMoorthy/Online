using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingSystem.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMap()
        {
            AutoMapper.Mapper.Initialize(config => { config.CreateMap<ProductModel,Product >();
                config.CreateMap<CategoryModel, Category>();
                config.CreateMap<LoginView, Account>();
                config.CreateMap<SignUpModel, Account>();
            });
                }
    }
}