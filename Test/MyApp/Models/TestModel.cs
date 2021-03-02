using MyContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    class TestModel
    {
        internal List<Verb> TestList { get; set; }
        internal List<Verb> WontBeCorrectList { get; set; }
        internal List<Verb> WillBeCorrectList { get; set; }
        public TestModel()
        {
            TestList = new List<Verb>();
            WontBeCorrectList = new List<Verb>();
            WillBeCorrectList = new List<Verb>();
        }
        internal IEnumerable<Verb> FindByTranslation(string search)
        {
            return TestList.Where(
                item => item.Translation.Equals(search.ToLower()));
        }
        internal IEnumerable<Verb> FindByAll(string translation, string infinitive, string pastSimple, string pastParticiple)
        {
            return FindByTranslation(translation.ToLower()).Where(
                item => item.Infinitive.Equals(infinitive.ToLower())
                && item.PastSimple.Equals(pastSimple.ToLower())
                && item.PastParticiple.Equals(pastParticiple.ToLower()));
        }
        internal Verb GetFirstElement()
        {
            return TestList.FirstOrDefault();
        }
        internal void Clear()
        {
            TestList.Clear();
            WontBeCorrectList.Clear();
            WillBeCorrectList.Clear();
        }
    }
}
