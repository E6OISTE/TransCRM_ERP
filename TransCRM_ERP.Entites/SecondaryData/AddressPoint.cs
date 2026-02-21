using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.SecondaryData
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class AddressPoint : InfoDateTimeCreate
    {
        /// <summary>Первичный ключ</summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>Адрес</summary>
        public required string AddressPointText { get; set; }

        /// <summary>
        /// Навигационные свойства => 
        /// <inheritdoc cref="DrivingRoute"/>
        /// => Погрузка
        /// </summary>
        public ICollection<DrivingRoute> AddressLoading { get; private set; }
        /// <summary>
        /// Навигационные свойства => 
        /// <inheritdoc cref="DrivingRoute"/>
        /// => Разгрузка
        /// </summary>
        public ICollection<DrivingRoute> AddressUnloading { get; private set; }
    }
}