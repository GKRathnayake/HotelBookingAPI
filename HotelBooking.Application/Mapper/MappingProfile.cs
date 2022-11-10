﻿using AutoMapper;
using HotelBooking.Application.ViewModels;
using HotelBooking.Entity.Entities;

namespace HotelBooking.Application.Mapper
{
    /// <summary>
    /// MappingProfile for AutoMapper
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfile"/> class.
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Hotel, HotelVM>();
            CreateMap<HotelVM, Hotel>();
        }
    }
}