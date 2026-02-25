using System.ComponentModel.DataAnnotations;
using TransCRM_ERP.Entites.TechnicalData;

namespace TransCRM_ERP.Entites.BaseData
{
    /// <summary>
    /// Транспортная накладная
    /// </summary>
    public class Waybill : TechnicalData.TechnicalData
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid ID { get; private set; }

        /// <summary>
        /// Номер ТН
        /// </summary>
        public required string WaybillNumb { get; set; }

        /// <summary>
        /// Дата ТН (Дата документа)
        /// </summary>
        public DateOnly WaybillDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        /// <summary>
        /// Тоннаж (заявленно)
        /// </summary>
        public float? Tons { get; set; }

        /// <summary>
        /// Кол-во грузовых мест (заявленно)
        /// </summary>
        public uint? Pieces { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        //public List<DrivingRoute>? DrivingRoute { get; set; }

        ///<summary>
        ///Тоннаж погрузка (факт) 0 == без факта взвешивания
        ///</summary>
        public float? TonsLoadingFact { get; set; }

        /// <summary>
        /// Кол-во мест погрузка (факт)
        /// </summary>
        public uint? PiecesLoadingFact { get; set; }

        /// <summary>
        /// Тоннаж разгрузка (факт) 0 == без факта взвешивания
        /// </summary>
        public float? TonsUnloadingFact { get; set; }

        /// <summary>
        /// Кол-во мест разгрузка (факт)
        /// </summary>
        public uint? PiecesUnloadingFact { get; set; }

        /// <summary>
        /// Таблица с Заявкой => Внешний ключ
        /// </summary>
        public Guid RequiredID { get; set; }
        /// <summary>
        /// Таблица с Заявкой => Обратное свойство
        /// </summary>
        public Required Required { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
    }
}