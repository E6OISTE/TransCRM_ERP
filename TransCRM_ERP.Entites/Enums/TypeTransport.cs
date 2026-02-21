using System.Text.Json.Serialization;

namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>
    /// Вид транспортного средства (ТС)
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeTransport : uint
    {
        /// <summary>
        /// Одиночный а/м
        /// </summary>
        SingleCar = 1,

        /// <summary>
        /// Седельный тягач
        /// </summary>
        TruckTractor = 2
    }
}