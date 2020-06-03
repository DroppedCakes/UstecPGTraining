using System;

namespace ProgrammingTraining.Infrastructure
{
    public class Workitem
    {
        /// <summary>
        ///
        /// </summary>
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
        /// 受付日時
        /// </summary>
        public DateTime ReceiptedAt { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// 漢字氏名
        /// </summary>
        public string NameKanji { get; set; }


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
    }
}