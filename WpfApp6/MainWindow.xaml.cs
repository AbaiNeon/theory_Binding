using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Order> orders;
        public MainWindow()
        {
            InitializeComponent();

            orders = new ObservableCollection<Order>()
            {
                new Order
                {
                    Id=1,
                    Name="Булочка",
                    Price=50,
                    ExpirationDate = DateTime.Now.AddDays(1)
                },
                new Order
                {
                    Id=2,
                    Name="Хлеб",
                    Price=70,
                    ExpirationDate = DateTime.Now.AddDays(1)
                }
            };

            dataContainer.ItemsSource = orders;
        }

        private void dataContainerAddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            orders.Add(new Order
            {
                Id = 2,
                Name = "Сникерс",
                Price = 70,
                ExpirationDate = DateTime.Now.AddDays(1)
            });
        }
    }
}
