using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilmoviCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TimeSpan day_diff = new TimeSpan(DateTime.Now.Ticks - new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Ticks);
            List<int> days = new List<int>();
            for (int i = 1; i <= day_diff.Days; i++)
            {
                days.Add(i);
            }

            myGrid = new DataGrid_AcrobatX(days);
        }
    }
}
