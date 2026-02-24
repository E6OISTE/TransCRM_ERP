using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.Enums;

namespace TransCRM_ERP.DTO
{
    /// <summary>
    /// DTO => Read => <inheritdoc cref="Autotransport"/>
    /// </summary>
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

    /// <summary>
    /// DTO => ReadBase => <inheritdoc cref="Autotransport"/>
    /// </summary>
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
    /// DTO => Create => <inheritdoc cref="Autotransport"/>
    /// </summary>
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
