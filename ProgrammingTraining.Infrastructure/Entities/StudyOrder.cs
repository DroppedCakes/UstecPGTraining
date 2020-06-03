using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProgrammingTraining.Infrastructure.Entities
{
    /// <summary>
    /// 検査依頼データ
    /// </summary>
    [Table("StudyOrder")]
    public class StudyOrder
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// オーダ番号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 患者基本属性データID
        /// </summary>
        public long PatientInfoId { get; set; }

        /// <summary>
        /// 検査種別データID
        /// </summary>
        public long ModalityId { get; set; }

        /// <summary>
        /// 依頼日付(yyyyMMdd形式の文字列)
        /// </summary>
        public string OrderingDate { get; set; }

        /// <summary>
        /// 予約日付(yyyyMMdd形式の文字列)
        /// </summary>
        public string ScheduledDate { get; set; }

        /// <summary>
        /// 受付日時
        /// </summary>
        public DateTime ReceiptedAt { get; set; }

        /// <summary>
        /// 実施日時
        /// </summary>
        public DateTime PerformedAt { get; set; }

        /// <summary>
        /// 登録日時
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
