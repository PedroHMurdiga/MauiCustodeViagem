using MauiCustodeViagem.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCustodeViagem.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<pedagio>().Wait();
        }

        public Task<int> Insert(pedagio p)
        {
            return _conn.InsertAsync(p);

        }
        public Task<int> Delete(int id)
        {
            return _conn.Table<pedagio>().DeleteAsync();
        }

        public Task<List<pedagio>> GetAll()
        {
            return _conn.Table<pedagio>().ToListAsync();
        }

    }
}
