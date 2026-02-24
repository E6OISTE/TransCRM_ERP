using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.BaseData;

namespace TransCRM_ERP.DTO
{
    /// <summary>
    /// DTO => ReadFull => <inheritdoc cref="Passport"/>
    /// </summary>
    public record PassportReadFullDto(
        Guid Id,
        uint SeriesPassport,
        uint NumberPassport,
        DateOnly DateIssue,
        int DepartmentCode,
        string IssuedBy,
        string Gender,
        DateOnly Birthdate,
        string Birthplace,
        Driver Driver
        );

    /// <summary>
    /// DTO => Read => <inheritdoc cref="Passport"/>
    /// </summary>
    public record PassportReadBaseDto(
        Guid Id,
        uint SeriesPassport,
        uint NumberPassport,
        DateOnly DateIssue,
        int DepartmentCode,
        string IssuedBy,
        string Gender,
        DateOnly Birthdate,
        string Birthplace
        );

    /// <summary>
    /// DTO => Create => <inheritdoc cref="Passport"/>
    /// </summary>
    public record PassportCreateDto(
        uint SeriesPassport,
        uint NumberPassport,
        DateOnly DateIssue,
        int DepartmentCode,
        string IssuedBy,
        string Gender,
        DateOnly Birthdate,
        string Birthplace,
        Driver Driver
        );
}
