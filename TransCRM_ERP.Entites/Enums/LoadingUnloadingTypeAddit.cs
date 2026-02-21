using System.Text.Json.Serialization;

namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>
    /// Тип загрузки/выгрузки и Дополнительные параметры
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LoadingUnloadingTypeAddit : uint
    {
        /// <summary>
        /// Пломбировочный трос
        /// </summary>
        SealingCable = 1,

        /// <summary>
        /// Манипулятор
        /// </summary>
        Manipulator,

        /// <summary>
        /// Гидроборт
        /// </summary>
        TailLift,

        /// <summary>
        /// Ремни
        /// </summary>
        Strapping,

        /// <summary>
        /// Коники
        /// </summary>
        Grasshoppers,

        /// <summary>
        /// Задняя
        /// </summary>
        Back,

        /// <summary>
        /// Боковая
        /// </summary>
        Side,

        /// <summary>
        /// Верхняя
        /// </summary>
        Top
    }
}