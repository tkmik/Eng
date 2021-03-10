using MyApp.Services;
using MyContext.Context;
using MyContext.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class VerbRepository : IRepository
    {
        private VerbContext database { get; set; }
        public IEnumerable<Verb> Verbs { get; set; }
        public VerbRepository()
        {
            database = new VerbContext();
            Verbs = database.Verbs.Local;
        }
        public IEnumerable<Verb> Search(string text)
        {
            return Verbs.Where(item => item.Infinitive.Contains(text)
                || item.PastSimple.Contains(text)
                || item.PastParticiple.Contains(text)
                || item.Translation.Contains(text));
        }

        public IEnumerable<Verb> SearchByNumberOfGroup(int value)
        {
            return Verbs.Where(number => number.NumberOfGroup == value);
        }
        public async Task LoadAll()
        {
            await database.Verbs.LoadAsync();
        }
        public async Task SaveToDatabase()
        {
            await database.SaveChangesAsync();
        }
        public string SaveToJsonFile()
        {
            return Serialize();
        }
        public IEnumerable<Verb> LoadFromJsonFile(string json)
        {
            Verbs = Deserialize(json);
            return Verbs;
        }
        public void Close()
        {
            database.Dispose();            
        }
        private string Serialize()
        {
            return JSONConverter<Verb>.Serialize(Verbs);
        }
        private IEnumerable<Verb> Deserialize(string json)
        {

            return JSONConverter<Verb>.Deserialize(json);
        }
    }
}
