﻿using AutoMapper;
using GestionPaieApi.DTOs;
using GestionPaieApi.Models;

namespace GestionPaieApi.Mapper
{
    public class DocumentsProfile : Profile
    {
        public DocumentsProfile() {
            CreateMap<LettreAccompagnee, LettreAccompagneeDto>();
            CreateMap<LettreAccompagneeDto, LettreAccompagnee>();
        }
        
    }
}
