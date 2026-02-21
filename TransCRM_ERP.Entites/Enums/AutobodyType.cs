using System.Text.Json.Serialization;

namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>
    /// Тип кузова
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutobodyType : uint
    {
        /// <summary>
        /// Фронтальный погрузчик
        /// </summary>
        
        FrontLoader = 1,

        /// <summary>
        /// Манипулятор
        /// </summary>
        Manipulator,

        /// <summary>
        /// Экскаватор
        /// </summary>
        Excavator,

        /// <summary>
        /// Сцепка
        /// </summary>
        Coupling,

        /// <summary>
        /// Контейнеровоз
        /// </summary>
        ContainerShip,

        /// <summary>
        /// Трал
        /// </summary>
        Thrall,

        /// <summary>
        /// Бортовой прицеп
        /// </summary>
        FlatbedTrailer,

        /// <summary>
        /// Самосвал
        /// </summary>
        DumpTruck,

        /// <summary>
        /// Эвакуатор
        /// </summary>
        TowTruck,

        /// <summary>
        /// Кран
        /// </summary>
        Crane,

        /// <summary>
        /// Седельный тягач
        /// </summary>
        TruckTractor,

        /// <summary>
        /// Тент
        /// </summary>
        Tent,

        /// <summary>
        /// Другое
        /// </summary>
        Other
    }
}