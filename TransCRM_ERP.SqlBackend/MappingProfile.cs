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
            CreateMap<Autotransport, AutotransportReadFullDto>();
            CreateMap<Autotransport, AutotransportReadBaseDto>();

            CreateMap<Driver, DriverReadFullDto>();
            CreateMap<Driver, DriverReadBaseDto>();

            CreateMap<DriverLicense, DriverLicenseReadFullDto>();

            /// DTO => Class
            /// For POST/PUT req
            CreateMap<AutotransportCreateDto, Autotransport>();

            CreateMap<DriverCreateDto, Driver>();

            CreateMap<DriverLicenseCreateDto, DriverLicense>();
        }
    }
}