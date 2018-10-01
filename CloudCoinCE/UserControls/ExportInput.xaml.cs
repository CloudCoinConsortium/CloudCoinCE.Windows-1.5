using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CloudCoinCE.UserControls
{
    /// <summary>
    /// Interaction logic for ExportInput.xaml
    /// </summary>
    public partial class ExportInput : UserControl
    {
        public string label = "1s";
        public string Lbl
        {
            get { return label; }
            set { { label = value; lblName.Content = label; } }
        }

        public int count = 0;
        public int Count
        {
            get { return count; }
            set { { count = value; txtCount.Text = Convert.ToString(count); } }
        }
        public ExportInput()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Count = Convert.ToInt16(txtCount.Text);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
