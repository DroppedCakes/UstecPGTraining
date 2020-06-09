using System;
using System.Collections.Generic;

namespace ProgrammingTraining.Infrastructure.Repositories
{
    public class StudyOrderRepository
    {
        private static readonly string[] SexCodes = {
            "F",
            "M",
            "O",
        };

        private readonly Random _random = new Random();

        public IEnumerable<Workitem> FetchWorkitems(DateTime? since, DateTime? until, string patientId)
        {
            // TODO
            return CreateWorkitems();
        }

        public IEnumerable<Workitem> CreateWorkitems()
        {
            for (int i = 1; i != 20; i++)
            {
                yield return CreateWorkitem(i);
            }
        }

        public Workitem CreateWorkitem(int i)
        {
            return new Workitem()
            {
                Id = i,
                PatientInfoId = i,
                PatientId = i.ToString(),
                // 0埋め10桁
                OrderNumber = String.Format("{0:D10}", i),
                NameKanji = $"テスト 患者{i}",
                NameWKana = $"テスト カンジャ{i}",
                ModalityId = i,
                OrderingDate = DateTime.Now.ToString("yyyyMMdd"),
                ReceiptedAt = new DateTime(0001, 01, 01),
                // 雑にランダムで性別を決定
                SexCode = SexCodes[this._random.Next(0,3)],
                BirthDate = new DateTime(2000, 12, 31)
            };
        }
    }
}