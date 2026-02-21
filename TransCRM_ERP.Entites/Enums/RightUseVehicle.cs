using System.Text.Json.Serialization;

namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>
    /// Право пользования ТС
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RightUseVehicle : uint
    {
        /// <summary>
        /// Собственность
        /// </summary>
        Own = 1,

        /// <summary>
        /// Безвозмездное пользование
        /// </summary>
        FreeUse,

        /// <summary>
        /// Совместная собственность супругов
        /// </summary>
        JointPropertySpouses,

        /// <summary>
        /// Аренда
        /// </summary>
        Rent,

        /// <summary>
        /// Лизинг
        /// </summary>
        Leasing,

        /// <summary>
        /// Экспедирование
        /// </summary>
        Forwarding
    }
}