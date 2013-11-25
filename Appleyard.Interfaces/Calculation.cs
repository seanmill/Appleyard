// property of Sean Mill
// sean.mill@talk21.com

using System;

namespace DUX.Interfaces
{
    public interface Calculation
    {
        bool DurationOfCalculationLife { get; set; }
        double DurationOfCalculationOther { get; set; }

        int IncomeNeed { get; set; }
        int StartingCapital { get; set; }
        bool PreserveOriginalCapital { get; set; }

        bool IncludeStatePension { get; set; }
        bool IsReverseCalculation { get; set; }

        System.Collections.Generic.List<Capital> OptionsCapitals { get; set; }
        System.Collections.Generic.List<Income> OptionsIncomes { get; set; }
        System.Collections.Generic.List<Stepup> OptionsStepups { get; set; }
    }

    public interface Income
    {
        int Amount { get; set; }
        int AgeStart { get; set; }
        int AgeEnd { get; set; }
        bool NICPayable { get; set; }
    }

    public interface Capital
    {
        int Amount { get; set; }
        int AtAge { get; set; }
        bool IncreaseWithInflationPriorToReceipt { get; set; }
    }

    public interface Stepup
    {
        bool IsIncrease { get; set; }
        bool IsAmount { get; set; }
        int Amount { get; set; }
        int Percentage { get; set; }

        bool IncreaseWithInflationPriorToReceipt { get; set; }
        int AgeStart { get; set; }

        bool IsForLife { get; set; } // if false, must specify AgeEnd
        int AgeEnd { get; set; }
    }
}
