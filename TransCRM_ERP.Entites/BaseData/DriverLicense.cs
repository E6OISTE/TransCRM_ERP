using System.ComponentModel.DataAnnotations;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Данные водительское удостоверение
    /// </summary>
    public class DriverLicense
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>
        /// Серия
        /// </summary>
        public required short SeriesLicence { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public required int NumberLicence { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public required DateOnly DateIssue { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public required DateOnly DateEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Driver Driver {  get; set; }
    }
}