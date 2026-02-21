using System.ComponentModel.DataAnnotations.Schema;

namespace TransCRM_ERP.Entites.TechnicalData
{
    [NotMapped]
    public abstract class InfoDateTimeCreate
    {
        /// <summary>
        /// LOGS => DateTime.Now
        /// </summary>
        /// <returns></returns>
        public virtual DateTime? InfoDateTimeCreateSet { get; private set; } = DateTime.Now;
    }
}