using MinMuhasebemD1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MinMuhasebemD1.DataBases
{
    public class MMContext
    {
        readonly SQLiteAsyncConnection _dataBase;
        public MMContext(string dbPath)
        {
            _dataBase = new SQLiteAsyncConnection(dbPath);
            _dataBase.CreateTableAsync<CreditCards>().Wait();
        }

        public  Task<List<CreditCards>> GetCreditCardsAsync()
        {
            return _dataBase.Table<CreditCards>().ToListAsync();
        }
    }
}
