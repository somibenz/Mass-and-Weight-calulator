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

namespace Mass_and_Weight
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal weight = decimal.Parse(textBox.Text) * 9.8M;
                label.Content = weight;
                if (weight > 1000)
                {
                    MessageBox.Show("It's too heavy");
                }
                if (weight < 10)
                {
                    MessageBox.Show("It's too light");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a valid input");
            }
        }
    }
}
