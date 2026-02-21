namespace TransCRM_ERP.Entites.Enums
{
    /// <summary>
    /// Статус заявки (Перевозки)
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Новая перевозка
        /// </summary>
        New,
        /// <summary>
        /// В ожидании перевозки
        /// </summary>
        Awaiting,
        /// <summary>
        /// На перевозке
        /// </summary>
        InProgress,
        /// <summary>
        /// Перевозка закончена
        /// </summary>
        Completed,
        /// <summary>
        /// Отмена перевозки
        /// </summary>
        Cancellation
    }
}