using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinMuhasebemD1.Models
{
    public class IncomeStatements
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double CashIncome { get; set; }
        public double CreditCardIncome { get; set; }
        public double CreditCardCommissionRate { get; set; }
        public double NetCreditCardIncome { get; set; }
        public DateTime IncomeDate { get; set; }
    }
}
