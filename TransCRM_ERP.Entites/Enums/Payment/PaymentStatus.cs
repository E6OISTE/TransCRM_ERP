namespace TransCRM_ERP.Entites.Enums.Payment
{
    /// <summary>
    /// Статус оплаты
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// В ожидании оплаты
        /// </summary>
        Awaiting = 1,

        /// <summary>
        /// Оплачено
        /// </summary>
        Paid = 2,

        /// <summary>
        /// Отмена
        /// </summary>
        Cancellation = 3
    }
}