using ProgrammingTraining.Infrastructure;
using System;
using Ustec.WpfHelpers;

namespace ProgrammingTraining.Worklist.ViewModels
{
    public class WorkitemViewModel : BindableModelBase
    {
        private readonly Workitem _workitem;

        /// <summary>
        /// 依頼日付(yyyyMMdd形式の文字列)
        /// </summary>
        public string OrderingDate { get => this._workitem.OrderingDate; }

        /// <summary>
        /// オーダ番号
        /// </summary>
        public string OrderNumber { get => this._workitem.OrderNumber; }

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientId { get => this._workitem.PatientId; }

        /// <summary>
        /// 漢字氏名
        /// </summary>
        public string NameKanji { get => this._workitem.NameKanji; }

        /// <summary>
        /// 全角カナ氏名
        /// </summary>
        public string NameWKana { get => this._workitem.NameWKana; }

        /// <summary>
        /// 性別コード(F,M,O)
        /// </summary>
        public string SexCode { get => this._workitem.SexCode; }

        /// <summary>
        /// 性別表示名称
        /// </summary>
        public string SexDisplayName
        {
            get
            {
                return this.SexCode switch
                {
                    "F" => "女",
                    "M" => "男",
                    "O" => "不明",
                    _ => "",
                };
            }
        }

        /// <summary>
        /// 生年月日
        /// </summary>
        public DateTime BirthDate { get => this._workitem.BirthDate; }

        public WorkitemViewModel(Workitem workitem)
        {
            this._workitem = workitem;
        }
    }
}