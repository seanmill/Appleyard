// property of Sean Mill
// sean.mill@talk21.com

using System;

namespace DUX
{
    public class Client
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public bool HideFromOthersInCompany { get; set; }
        public string LifeExpectancyTable { get; set; }
        public bool PaysUkTax { get; set; }

        public decimal CGTRecycleRate { get; set; }
        public decimal CapitalGrowth { get; set; }
        public decimal IncomeYield { get; set; }
        public decimal Inflation { get; set; }
    }
}
