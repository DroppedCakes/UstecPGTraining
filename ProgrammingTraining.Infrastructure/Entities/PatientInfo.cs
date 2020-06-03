using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProgrammingTraining.Infrastructure.Entities
{
    /// <summary>
    /// 患者基本属性データ
    /// </summary>
    [Table("PatientInfo")]
    public class PatientInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// 漢字氏名
        /// </summary>
        public string NameKanji { get; set; }

        /// <summary>
        /// 半角ｶﾅ氏名
        /// </summary>
        public string NameNKana { get; set; }

        /// <summary>
        /// ローマ字氏名
        /// </summary>
        public string NameRoman { get; set; }

        /// <summary>
        /// 全角カナ氏名
        /// </summary>
        public string NameWKana { get; set; }

        /// <summary>
        /// 性別コード(F,M,O)
        /// </summary>
        public string SexCode { get; set; }

        /// <summary>
        /// 生年月日
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 患者コメント
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 登録日時
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 削除日時
        /// </summary>
        public DateTime DeletedAt { get; set; }
    }
}
