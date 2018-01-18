using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Order:INotifyPropertyChanged
    {
        private int id;
        private string name;
        private double price;
        private DateTime expirationDate;
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
                //то же с остальными
            }
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            
        }
    }
}
