using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    internal class PieChartModel
    {
        internal class PiePoint
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }
        internal ObservableCollection<PiePoint> PieCollection { get; set; }

        public PieChartModel()
        {
            PieCollection = new ObservableCollection<PiePoint>();
        }
        internal void Add(string name, int value)
        {
            PieCollection.Add(new PiePoint() { Name = name, Value = value });
        }
        internal void Clear()
        {
            PieCollection.Clear();
        }

    }
}
