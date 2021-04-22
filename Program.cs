using System;
using System.IO;
using System.Text.Json;
using budget_manager_mapper.Models;
using budget_manager_mapper.Procesors;

namespace budget_manager_mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessor categoryProcessor = new Processor();
            // Estas dos no se deberian de necesitar mas
            // categoryProcessor.processFile<CategoryIn, CategoryOut>("jsons/expense-categories.json", "jsons/export/expense-categories-to-import.json");
            // categoryProcessor.processFile<CategoryIn, CategoryOut>("jsons/income-categories.json", "jsons/export/income-categories-to-import.json");

            // A partir de aqui es la migracion
            categoryProcessor.processFile<AccountIn, AccountOut>("jsons/accounts.json", "jsons/export/accounts-to-import.json");
            // categoryProcessor.processFile<TransferIn, TransferOut>("jsons/transfers.json", "jsons/export/transfers-to-import.json");
            // categoryProcessor.processFile<ExpenseIn, ExpenseOut>("jsons/expenses.json", "jsons/export/expenses-to-import.json");
            // categoryProcessor.processFile<IncomeIn, IncomeOut>("jsons/incomes.json", "jsons/export/incomes-to-import.json");
            
        }
    }
}
