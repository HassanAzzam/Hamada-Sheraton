using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Resturant
{
    /// <summary>
    /// Interaction logic for NewDelivery.xaml
    /// </summary>
    public partial class NewDelivery : Window
    {
        public NewDelivery()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //
            //      if customer found show MessageBox with customer details then MainWindow else, show NewCustomer window. 
            //
        }
    }
}
