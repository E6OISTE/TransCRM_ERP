using AutoMapper;
using TransCRM_ERP.DTO;
using TransCRM_ERP.Entites.BaseData;

namespace TransCRM_ERP.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /// Class => DTOa
            /// For GET req
            CreateMap<Required, RequiredReadBaseDto>();
            CreateMap<Required, RequiredReadFullDto>();

            CreateMap<Autotransport, AutotransportReadFullDto>();
            CreateMap<Autotransport, AutotransportReadBaseDto>();

            CreateMap<Driver, DriverReadFullDto>();
            CreateMap<Driver, DriverReadBaseDto>();

            CreateMap<DriverLicense, DriverLicenseReadFullDto>();

            CreateMap<Passport, PassportReadFullDto>();
            CreateMap<Passport, PassportReadBaseDto>();

            /// DTO => Class
            /// For POST/PUT req
            CreateMap<RequiredCreateDto, Required>();

            CreateMap<AutotransportCreateDto, Autotransport>();

            CreateMap<DriverCreateDto, Driver>();

            CreateMap<DriverLicenseCreateDto, DriverLicense>();

            CreateMap<PassportCreateDto, Passport>();
        }
    }
}