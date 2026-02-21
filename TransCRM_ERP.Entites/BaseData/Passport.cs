using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Паспорт
    /// </summary>
    public class Passport : InfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>
        /// Серия
        /// </summary>
        public required uint SeriesPassport { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public required uint NumberPassport { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public required DateOnly DateIssue { get; set; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        public required int DepartmentCode { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        public required string IssuedBy { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public required string Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public required DateOnly Birthdate { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public required string Birthplace { get; set; }

        /// <summary>
        /// Навигационное свойство => 
        /// <inheritdoc cref="BaseData.Driver"/>
        /// </summary>
        public Driver Driver { get; set; }
    }
}