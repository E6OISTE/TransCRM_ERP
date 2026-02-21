using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.Enums;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.DTO
{
    /// <summary>
    /// DTO <inheritdoc cref="Autotransport"/>
    /// </summary>
    /// <param name="Id"><inheritdoc cref="Autotransport.Id"/></param>
    /// <param name="TypeTransport"><inheritdoc cref="Autotransport.TypeTransport"/></param>
    /// <param name="AutobodyType"><inheritdoc cref="Autotransport.AutobodyType"/></param>
    /// <param name="CarRegNumber"><inheritdoc cref="Autotransport.CarRegNumber"/></param>
    /// <param name="RegionNumber"><inheritdoc cref="Autotransport.RegionNumber"/></param>
    /// <param name="CarBrand"><inheritdoc cref="Autotransport.CarBrand"/></param>
    /// <param name="CarModel"><inheritdoc cref="Autotransport.CarModel"/></param>
    /// <param name="Lifting"><inheritdoc cref="Autotransport.Lifting"/></param>
    /// <param name="CarVolume"><inheritdoc cref="Autotransport.CarVolume"/></param>
    /// <param name="SpaceDimensionsLength"><inheritdoc cref="Autotransport.SpaceDimensionsLength"/></param>
    /// <param name="SpaceDimensionsWidth"><inheritdoc cref="Autotransport.SpaceDimensionsWidth"/></param>
    /// <param name="SpaceDimensionsHeight"><inheritdoc cref="Autotransport.SpaceDimensionsHeight"/></param>
    /// <param name="LoadingUnloadingTypeAddit"><inheritdoc cref="Autotransport.LoadingUnloadingTypeAddit"/></param>
    /// <param name="RightUseVehicle"><inheritdoc cref="Autotransport.RightUseVehicle"/></param>
    /// <param name="CarRegistrationCertificateNumb"><inheritdoc cref="Autotransport.CarRegistrationCertificateNumb"/></param>
    /// <param name="CarRegistrationCertificateDate"><inheritdoc cref="Autotransport.CarRegistrationCertificateDate"/></param>
    public record AutotransportReadFullDto(
            Guid Id,
            TypeTransport TypeTransport,
            AutobodyType AutobodyType,
            string CarRegNumber,
            short RegionNumber,
            string CarBrand,
            string CarModel,
            float Lifting,
            float? CarVolume,
            float? SpaceDimensionsLength,
            float? SpaceDimensionsWidth,
            float? SpaceDimensionsHeight,
            LoadingUnloadingTypeAddit[]? LoadingUnloadingTypeAddit,
            RightUseVehicle? RightUseVehicle,
            string? CarRegistrationCertificateNumb,
            DateOnly? CarRegistrationCertificateDate
        );
    public record AutotransportReadBaseDto(
            Guid Id,
            TypeTransport TypeTransport,
            AutobodyType AutobodyType,
            string CarRegNumber,
            short RegionNumber,
            string CarBrand,
            string CarModel,
            float Lifting
        );
    /// <summary>
    /// 
    /// </summary>
    /// <param name="TypeTransport"></param>
    /// <param name="AutobodyType"></param>
    /// <param name="CarRegNumber"></param>
    /// <param name="RegionNumber"></param>
    /// <param name="CarBrand"></param>
    /// <param name="CarModel"></param>
    /// <param name="Lifting"></param>
    /// <param name="CarVolume"></param>
    /// <param name="SpaceDimensionsLength"></param>
    /// <param name="SpaceDimensionsWidth"></param>
    /// <param name="SpaceDimensionsHeight"></param>
    /// <param name="LoadingUnloadingTypeAddit"></param>
    /// <param name="RightUseVehicle"></param>
    /// <param name="CarRegistrationCertificateNumb"></param>
    /// <param name="CarRegistrationCertificateDate"></param>
    public record AutotransportCreateDto(
            TypeTransport TypeTransport,
            AutobodyType AutobodyType,
            string CarRegNumber,
            short RegionNumber,
            string CarBrand,
            string CarModel,
            float Lifting,
            float? CarVolume,
            float? SpaceDimensionsLength,
            float? SpaceDimensionsWidth,
            float? SpaceDimensionsHeight,
            LoadingUnloadingTypeAddit[]? LoadingUnloadingTypeAddit,
            RightUseVehicle? RightUseVehicle,
            string? CarRegistrationCertificateNumb,
            DateOnly? CarRegistrationCertificateDate
        );
}
