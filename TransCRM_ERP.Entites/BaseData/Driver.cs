using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Данные водителя
    /// </summary>
    public class Driver : InfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public required string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Отчество (Необязательно)
        /// </summary>
        public string? Lastname { get; set; }

        /// <summary>
        /// FK =>
        /// <inheritdoc cref="BaseData.DriverLicense"/>
        /// <inheritdoc cref="DriverLicense.Id"/>
        /// </summary>
        public Guid DriverLicenseId { get; set; }

        /// <summary>
        /// Навигационное свойство => 
        /// <inheritdoc cref="BaseData.DriverLicense"/>
        /// </summary>
        public required DriverLicense DriverLicense { get; set; }

        /// <summary>
        /// FK =>
        /// <inheritdoc cref="BaseData.Passport"/>
        /// <inheritdoc cref="Passport.Id"/>
        /// </summary>
        public Guid PassportId { get; set; }

        /// <summary>
        /// Навигационное свойство =>
        /// <inheritdoc cref="BaseData.Passport"/>
        /// </summary>
        public required Passport Passport { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// Гражданство
        /// </summary>
        public string? Citizenship { get; set; }

        /// <summary>
        /// Навигационное свойство => 
        /// <inheritdoc cref="BaseData.Required"/>
        /// </summary>
        public Required? Required { get; set; }
    }
}