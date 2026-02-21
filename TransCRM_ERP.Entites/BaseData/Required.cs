using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.Enums;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Заявка
    /// </summary>
    public class Required : InfoDateTimeCreate
    {
        ///<summary>
        ///Первичный ключ
        ///</summary>
        [Key]
        public Guid Id { get; private set; }

        ///<summary>
        ///Номер заявки
        ///</summary>
        public required string RequestNumb { get; set; }

        /// <summary>
        /// Дата Заявки
        /// </summary>
        public DateOnly RequestDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        /// <summary>
        /// Номер заявки доп. == NULL
        /// </summary>
        public string? RequestNumbAdd { get; set; }

        ///<summary>
        ///Начальная стоимость заявки
        ///</summary>
        public required double RequestCostStart { get; set; }

        /// <summary>
        /// Тип перевозки
        /// </summary>
        public required TypeTransportation TypeTransportation { get; set; }

        /// <summary>
        /// Массив маршрута
        /// </summary>
        public List<DrivingRoute> DrivingRoutes { get; set; } = new List<DrivingRoute>();

        /// <summary>
        /// Статус заявки (по умолчанию = Новая перевозка)
        /// </summary>
        /// <remarks>
        /// Автоматически инициализируется значением RequestStatus.New
        /// </remarks>
        public RequestStatus RequestStatus { get; set; } = RequestStatus.New;

        /// <summary>
        /// Транспортные накладные
        /// </summary>
        public List<Waybill>? Waybills { get; set; } = new();

        /// <summary>
        /// FK => 
        /// <inheritdoc cref="BaseData.Autotransport"/>
        /// </summary>
        public Guid? AutotransportId { get; set; }
        /// <summary>
        /// Навигационное свойство => 
        /// <inheritdoc cref="BaseData.Autotransport"/>
        /// </summary>
        public Autotransport? Autotransport { get; set; } = null!;

        /// <summary>
        /// FK => 
        /// <inheritdoc cref="TransCRM_ERP.Entites.BaseData.Driver"/>
        /// </summary>
        public Guid? DriverId { get; set; }
        /// <summary>
        /// Поле Водитель => 
        /// <inheritdoc cref="BaseData.Driver"/>
        /// </summary>
        public Driver? Driver { get; set; } = null;

        //  ДОДЕЛАТЬ Логику!!!
        /// <summary>
        /// Конечная стоимость заявки (RequestCostStart * RequestCostCount)
        /// </summary>
        public double RequestCostFinal { get; set; }

        /// <summary>
        /// Комментарий к заявке
        /// </summary>
        public string? Comment { get; set; } = null;
    }
}