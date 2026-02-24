using TransCRM_ERP.Entites.BaseData;

namespace TransCRM_ERP.DTO
{
    /// <summary>
    /// DTO => ReadFull => <inheritdoc cref="DriverLicense"/>
    /// </summary>
    public record DriverLicenseReadFullDto(
        Guid Id,
        short SeriesLicence,
        int NumberLicence,
        DateOnly DateIssue,
        DateOnly DateEnd,
        Driver Driver
        );

    /// <summary>
    /// DTO => Create => <inheritdoc cref="DriverLicense"/>
    /// </summary>
    public record DriverLicenseCreateDto(
        short SeriesLicence,
        int NumberLicence,
        DateOnly DateIssue,
        DateOnly DateEnd
        //Driver Driver
        );
}