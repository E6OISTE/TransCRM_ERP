namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>Тип перевозки</summary>
    public enum TypeTransportation
    {
        ///<summary>
        /// Почасовая оплата 
        /// Погрузка А => Выгрузка А 
        /// (Цена за 1 час * кол-во часов)
        /// </summary>
        HourlyRate = 1,

        /// <summary>
        /// Обычная перевозка
        /// Погрузка A => Выгрузка B
        /// </summary>
        RegularTransportation = 2,

        /// <summary>
        /// Сложная перевозка
        /// Погрузка А => Погрузка В;
        /// Погрузка А => Погрузка C
        /// </summary>
        DifficultTransportation = 3,

        /// <summary>
        /// Круговая перевозка
        /// Погрузка А => Погрузка Б;
        /// Погрузка Б => Погрузка A
        /// </summary>
        RoundaboutTransportation = 4
    }
}