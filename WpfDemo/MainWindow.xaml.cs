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

namespace WpfDemo
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

        private void btnClickOk(object sender, RoutedEventArgs e)
        {
            bool hasCheckbox1 = checkbox1.IsChecked == true ? true:false;
            bool hasCheckbox2 = checbox2.IsChecked == true ? true : false;
            string valueTextBox= txtTextBox.Text;

            bool male = radioMale.IsChecked == true;
            bool female= radioFemale.IsChecked == true;

            MessageBox.Show($"{hasCheckbox1}-{hasCheckbox2}-{valueTextBox}");
           
        }

        private void radioMaleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton radioMadle = (RadioButton)sender;
            if (radioFemale != null)
            {

            }
        }

       
    }
}