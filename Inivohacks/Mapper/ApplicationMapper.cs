﻿using AutoMapper;

namespace Inivohacks.Mapper
{
    public class ApplicationMapper :  Profile
    {
        public ApplicationMapper() 
        { 
        }
    }

    public static class MapperProvider
    {
        private static MapperConfiguration _mapperconfig;
        private static IMapper _mapper;

        static MapperProvider()
        {
            Initialize();
        }
        private static MapperConfiguration MapperConfig
        {
            get
            {
                return _mapperconfig;
            }
        }

        public static IMapper Mapper
        {
            get
            {
                return _mapper;
            }
        }

        public static void Initialize()
        {
            CreateMapperConfig();
            CreateMapper();
        }

        private static void CreateMapperConfig()
        {
            _mapperconfig = new MapperConfiguration(mc => { mc.AddProfile(new ApplicationMapper()); });
        }

        private static void CreateMapper()
        {
            _mapper = MapperConfig.CreateMapper();
        }


    }

}