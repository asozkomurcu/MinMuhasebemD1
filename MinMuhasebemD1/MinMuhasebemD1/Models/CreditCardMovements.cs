using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinMuhasebemD1.Models
{
    public class CreditCardMovements
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int CreditCardId { get; set; }
        public int SupplierId { get; set; }
        public double CreditCardPayments { get; set; }
        public double CreditCardCharges { get; set; }

        public CreditCards CreditCards { get; set; }
        public Supplier Supplier { get; set; }
    }
}
