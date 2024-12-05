using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using SpendWise.Models;

namespace SpendWise.Services
{
    internal class DatabaseService
    {
        private SQLiteConnection _database;

        public DatabaseService()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "SpendWise.db");
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Expense>();
            _database.CreateTable<Budget>();
        }

        public List<Expense> GetExpense() => _database.Table<Expense>().ToList();
        public void AddExpense(Expense expense) => _database.Insert(expense);

        public List<Budget> GetBudget() => _database.Table<Budget>().ToList();
        public void AddBudget(Budget budget) => _database.Insert(budget);
        public void UpdateBudget(Budget budget) => _database.Update(budget);
    }
}
