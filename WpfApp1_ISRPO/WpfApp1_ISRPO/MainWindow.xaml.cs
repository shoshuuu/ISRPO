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

namespace WpfApp1_ISRPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HotDrink current;
        string displayedImage;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbAmericano_Checked(object sender, RoutedEventArgs e)
        {
            current = new Americano();
            displayedImage = "/SRC/kofe-amerikano-v-domashnix-usoviyax.jpg";
        }

        private void rbEspresso_Checked(object sender, RoutedEventArgs e)
        {
            current = new Espresso();
            displayedImage = "/SRC/pravilnyj-espresso-v-domashnix-usloviyax-1.jpg";
        }

        private void rbCappucino_Checked(object sender, RoutedEventArgs e)
        {
            current = new Cappucino();
            displayedImage = "/SRC/Капучино-1140x1086.jpg";
        }

        private void rbCacao_Checked(object sender, RoutedEventArgs e)
        {
            current = new Cacao();
            displayedImage = "/SRC/cacao.jpg";
        }

    }
}
