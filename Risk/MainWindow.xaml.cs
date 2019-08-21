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

namespace Risk
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

        // All players start with 20 troops each.
        // There are a total of 42 territories.
        // North America = 9
        // South America = 4
        // Europe = 7
        // Asia = 12
        // Africa = 6
        // Australia = 4
        public int Black;
        public int Green;
        public int Blue;
        public int Red;
        public int Yellow;
        readonly string[] territories = new string[] { "Alaska","Northwest Territory", "Greenland", "Quebec","Alberta","Eastern US","Western US", "Central America","Venezuela","Brazil","Peru","Argentina" };
        private Dictionary<string, string> ContinentsAndTerritories = new Dictionary<string, string>();

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            CalculateTroops();
        }

        private int CalculateTroops()
        {
            LabelAlaska.Content = "1";
            return 1;
        }

    }
}
