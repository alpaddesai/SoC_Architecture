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

namespace SystemOnChip
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

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Interconnect_Click(object sender, RoutedEventArgs e)
        {
            Interconnect InterconnectObject = new Interconnect();
            InterconnectObject.Show();
        }

        private void SoC_Customization_Click(object sender, RoutedEventArgs e)
        {
            SoC_Customizationxaml SoC_CustomizationxamlObject = new SoC_Customizationxaml();
            SoC_CustomizationxamlObject.Show();
        }

        private void Memory_Addressing_Click(object sender, RoutedEventArgs e)
        {
            Memory_Addressing Memory_AddressingObject = new Memory_Addressing();
            Memory_AddressingObject.Show();
        }

        private void RichTextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
