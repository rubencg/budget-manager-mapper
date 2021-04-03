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
            Processor categoryProcessor = new Processor();
            // Estas dos no se deberian de necesitar mas
            // categoryProcessor.processFile<CategoryIn, CategoryOut>("jsons/expense-categories.json", "expense-categories-to-import.json");
            // categoryProcessor.processFile<CategoryIn, CategoryOut>("jsons/income-categories.json", "income-categories-to-import.json");

            // A partir de aqui es la migracion
            // categoryProcessor.processFile<AccountIn, AccountOut>("jsons/accounts.json", "accounts-to-import.json");
            categoryProcessor.processFile<TransferIn, TransferOut>("jsons/transfers.json", "transfers-to-import.json");
        }
    }
}
