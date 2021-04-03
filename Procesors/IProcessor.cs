using System;

namespace budget_manager_mapper.Procesors
{
    public interface IProcessor
    {
         void processFile<T, K>(String fileName, string outputFilename);
    }
}