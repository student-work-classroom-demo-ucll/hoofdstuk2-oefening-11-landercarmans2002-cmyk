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

namespace oefening2._1_startercode
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

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            lblOne.Content = "ja";
            lblTwo.Content = "ja";
            lblThree.Content = "ja";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            lblOne.Content = "nee";
            lblTwo.Content = "nee";
            lblThree.Content = "nee";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            lblOne.Content = "A";
            lblTwo.Content = "B";
            lblThree.Content = "C";
        }
    }
}