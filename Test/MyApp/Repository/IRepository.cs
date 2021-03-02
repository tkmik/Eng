using MyContext.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal interface IRepository
    {
        IEnumerable<Verb> Search(string text);
        IEnumerable<Verb> SearchByNumberOfGroup(int value);
        Task LoadAll();
        Task SaveToDatabase();
        string SaveToJsonFile();
        IEnumerable<Verb> LoadFromJsonFile(string json);
        void Close();
    }
}
