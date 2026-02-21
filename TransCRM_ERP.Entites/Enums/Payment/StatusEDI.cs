namespace TransCRM_ERP.Entites.Enums.Payment
{
    /// <summary>
    /// Статус документа ЭДО
    /// </summary>
    public enum StatusEDI : uint
    {
        /// <summary>
        /// Черновик
        /// </summary>
        Draft = 0,

        /// <summary>
        /// Отправлено
        /// </summary>
        Sent,

        /// <summary>
        /// Отказано в подписи
        /// </summary>
        SignatureDenied,

        /// <summary>
        /// Требуется уточнение
        /// </summary>
        NeedClarification,

        /// <summary>
        /// Подписан контрагентом
        /// </summary>
        Signed
    }
}