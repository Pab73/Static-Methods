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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp28._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSchrikkeljaar_Click(object sender, RoutedEventArgs e)
        {
            lblBoolean.Content = Schrikkeljaar.IsSchrikkeljaar(Convert.ToInt32(txtSchrikkeljaar.Text)) ? "true" : "false";
        }

        private void btnConversie_Click(object sender, RoutedEventArgs e)
        {
            //lblConversie.Content = EuroConversie.ToEuro(Convert.ToDecimal(txtConversie.Text)) + Environment.NewLine + EuroConversie.ToBef(Convert.ToDecimal(txtConversie.Text));
            lblConversie.Content = $"{EuroConversie.ToEuro(Convert.ToDecimal(txtConversie.Text)):0.00} {"€"} {Environment.NewLine}{EuroConversie.ToBef(Convert.ToDecimal(txtConversie.Text)):0.00} {"BEF"}";
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            lblControle.Content = Rijksregisternummer.Isvalid(txtRRnr.Password) ? "true" : "false";
        }
    }
}
