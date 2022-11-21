using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBindingCollectionsApp
{
    internal class DataSource
    {
        private ICollection<int> nonNotifiableCollection = new List<int> { 1, 2, 3 };
        private ICollection<int> notifiableCollection = new ObservableCollection<int> { 1, 2, 3 };

        public IEnumerable<int> NonNotifiableCollection { get => nonNotifiableCollection; }
        public IEnumerable<int> NotifiableCollection { get => notifiableCollection; }


        public void AddNonNotifiableCollection()
        {
            nonNotifiableCollection.Add(nonNotifiableCollection.Count + 1);
            string msg = "";
            foreach (var item in nonNotifiableCollection)
                msg += item.ToString() + "\n";
            MessageBox.Show(msg);
        }

        public void AddNotifiableCollection()
        {
            notifiableCollection.Add(notifiableCollection.Count + 1);
        }

    }
}
