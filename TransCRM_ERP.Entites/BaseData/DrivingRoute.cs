using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.SecondaryData;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    ///<summary>
    ///Маршрут движения
    ///</summary>
    public class DrivingRoute : TechnicalData.TechnicalData
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>
        /// Дата погрузки
        /// </summary>
        public required DateTime DataLoading { get; set; }

        /// <summary>
        /// Дата погрузки факт (прибытие)
        /// </summary>
        public DateTime? DataLoadingFact { get; set; }

        /// <summary>
        /// Внешний ключ => Адрес пункта погрузки
        /// </summary>
        public Guid AddressLoadingId { get; set; }
        /// <summary>
        /// Адрес пункта погрузки
        /// </summary>
        public required AddressPoint AddressLoading { get; set; } = null;

        /// <summary>
        /// Дата выгрузки
        /// </summary>
        public required DateTime DateUnloading { get; set; }

        /// <summary>
        /// Дата выгрузки факт (убытие)
        /// </summary>
        public DateTime? DateUnloadingFact { get; set; }

        /// <summary>
        /// Внешний ключ => Адрес пункта погрузки
        /// </summary>
        public Guid AddressUnloadingId { get; set; }
        /// <summary>
        /// Адрес пункта выгрузки
        /// </summary>
        public required AddressPoint AddressUnloading { get; set; }

        /// <summary>
        /// Статус присвоения к ТН (по умолчанию == false)
        /// </summary>
        public bool AssignmentStatusTN { get; set; } = false;

        /// <summary>
        /// Обратное свойство =>
        /// <inheritdoc cref="BaseData.Required"/>
        /// <inheritdoc cref="BaseData.Required.Id"/>
        /// </summary>
        public Guid RequiredID { get; set; }
        /// <summary>
        /// Обратное свойство =>
        /// <inheritdoc cref="BaseData.Required"/>
        /// </summary>
        public Required Required { get; set; }
    }
}