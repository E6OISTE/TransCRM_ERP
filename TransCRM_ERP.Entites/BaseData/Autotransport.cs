using TransCRM_ERP.Entites.Enums;
using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Автотранспорт
    /// </summary>
    public class Autotransport : InfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; private set; }

        /// <summary>
        /// Вид ТС
        /// </summary>
        public required TypeTransport TypeTransport { get; set; }

        /// <summary>
        /// Тип кузова
        /// </summary>
        public required AutobodyType AutobodyType { get; set; }

        /// <summary>
        /// Госномер
        /// </summary>
        public required string CarRegNumber { get; set; }

        /// <summary>
        /// Номер региона
        /// </summary>
        public required short RegionNumber { get; set; }

        /// <summary>
        /// Марка авто
        /// </summary>
        public required string CarBrand { get; set; }

        /// <summary>
        /// Модель авто
        /// </summary>
        public required string CarModel {  get; set; }

        /// <summary>
        /// Грузоподъёмность в тоннах
        /// </summary>
        public required float Lifting { get; set; }

        /// <summary>
        /// Объём (Длина * ширина * высота), м3
        /// </summary>
        public float? CarVolume { get; set; }

        /// <summary>
        /// Габариты пространства (длина), м
        /// </summary>
        public float? SpaceDimensionsLength { get; set; }

        /// <summary>
        /// Габариты пространства (ширина), м
        /// </summary>
        public float? SpaceDimensionsWidth { get; set; }

        /// <summary>
        /// Габариты пространства (высота), м
        /// </summary>
        public float? SpaceDimensionsHeight { get; set; }

        /// <summary>
        /// Тип загрузки/выгрузки и Дополнительные параметры
        /// </summary>
        public LoadingUnloadingTypeAddit[]? LoadingUnloadingTypeAddit { get; set; }
        
        /// <summary>
        /// Право пользования ТС
        /// </summary>
        public RightUseVehicle? RightUseVehicle { get; set; }

        /// <summary>
        /// Свидетельство о регистрации ТС -> Серия/номер
        /// </summary>
        public string? CarRegistrationCertificateNumb { get; set; }

        /// <summary>
        /// Свидетельство о регистрации ТС -> Дата выдачи
        /// </summary>
        public DateOnly? CarRegistrationCertificateDate { get; set; }
        
        /// <summary>
        /// Навигационное свойство => 
        /// <inheritdoc cref="BaseData.Required"/>
        /// </summary>
        public Required? Required { get; set; }
    }
}