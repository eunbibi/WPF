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

namespace Eunbi_Seo_Sec005_COMP212_Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double newTotal = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;

            //check box
            if (flossing.IsChecked == true)
            {
                total += 20;
            }
            if (filling.IsChecked == true)
            {
                total += 75;
            }
            if (root.IsChecked == true)
            {
                total += 150;
            }

            //radio button
            if (senior.IsChecked == true)
            {
                total = total - (total * 0.1);
            }
            else if (kid.IsChecked == true)
            {
                total = total - (total * 0.15);
            }

            //combo box
            newTotal = ComboBoxDoes(total);

            result.Text = patientNames.Text + "'s total price is: $" + newTotal.ToString();
        }

        public double ComboBoxDoes(double total)
        {
            switch (cmbSelect.SelectedItem.ToString().Split(new string[] { "- " }, StringSplitOptions.None).Last())
            {
                case "HST 7%":
                    //Handle for the first combobox
                    newTotal = total + (total * 0.07);
                    break;

                case "HST 13%":
                    //Handle for the second combobox
                    newTotal = total + (total * 0.13);
                    break;

                case "HST 6%":
                    //Handle for the third combobox
                    newTotal = total + (total * 0.06);
                    break;
            }

            return newTotal;
        }

        private void cmbSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void kid_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
