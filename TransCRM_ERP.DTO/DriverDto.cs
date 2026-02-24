using TransCRM_ERP.Entites.BaseData;

namespace TransCRM_ERP.DTO
{
    /// <summary>
    /// DTO => ReadBase => <inheritdoc cref="Driver"/>
    /// </summary>
    public record DriverReadBaseDto(
        Guid Id,
        string Surname,
        string Name,
        string? Lastname,
        long PhoneNumber
        );

    /// <summary>
    /// DTO => ReadFull => <inheritdoc cref="Driver"/>
    /// </summary>
    public record DriverReadFullDto(
        Guid Id,
        string Surname,
        string Name,
        string? Lastname,
        Guid DriverLicenseId,
        DriverLicense DriverLicense,
        Guid PassportId,
        Passport Passport,
        long PhoneNumber,
        string? Citizenship,
        Required? Required
        );

    /// <summary>
    /// DTO => Create => <inheritdoc cref="Driver"/>
    /// </summary>
    public record DriverCreateDto(
        Guid Id,
        string Surname,
        string Name,
        string? Lastname,
        Guid DriverLicenseId,
        DriverLicense DriverLicense,
        Guid PassportId,
        Passport Passport,
        long PhoneNumber,
        string? Citizenship,
        Required? Required
        );
}