using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinMuhasebemD1.Models
{
    public class CreditCards
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string CardName { get; set; }
        public DateTime StatementDate { get; set; }
        public DateTime PaymentDueDate { get; set; }

        public ICollection<Payments> payments { get; set; }
        public ICollection<CreditCardMovements> creditCardMovements { get; set; }
    }
}
