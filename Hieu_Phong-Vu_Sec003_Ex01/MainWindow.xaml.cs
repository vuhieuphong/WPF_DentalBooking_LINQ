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

namespace Hieu_Phong_Vu_Sec003_Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double price=0;
        double hst=0;
        double discount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            TextBlockResult.Text = "Name: "+(TextBoxName.Text!=""?TextBoxName.Text:"Unspecified")+"- Total Charges: "
                +Math.Round((price + price * hst) * (1 - discount),2);
        }

        private void Services_Clicked(object sender,RoutedEventArgs e)
        {
            CheckBox checkBox=(CheckBox)sender;
            if (checkBox.IsChecked == true)
            {
                if (sender == CheckBoxFlossing)
                {
                    price += 20;
                }
                if (sender == CheckBoxFilling)
                {
                    price += 75;
                }
                if (sender == CheckBoxRootCanal)
                {
                    price += 150;
                }
            }
            else
            {
                if (sender == CheckBoxFlossing)
                {
                    price -= 20;
                }
                if (sender == CheckBoxFilling)
                {
                    price -= 75;
                }
                if (sender == CheckBoxRootCanal)
                {
                    price -= 150;
                }
            }
        }

        private void ComboBoxProvince_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxProvince.SelectedIndex == 0)
            {
                hst=0.07;
            }
            else if (ComboBoxProvince.SelectedIndex == 1)
            {
                hst = 0.13;
            }
            else if (ComboBoxProvince.SelectedIndex == 2)
            {
                hst = 0.06;
            }
        }

        private void Age_Clicked(object sender, RoutedEventArgs e)
        {
            if (sender == RadioButtonSenior)
            {
                discount = 0.1;
            }
            else if (sender == RadioButtonYouth)
            {
                discount = 0.15;
            }
            else if (sender == RadioButtonAdult)
            {
                discount = 0;
            }
        }
    }
}
