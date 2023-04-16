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

namespace CheckBoxThreeStateSample
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

        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            var isChecked = cbAllFeatures.IsChecked == true;
            cbFeatureAbc.IsChecked = isChecked;
            cbFeatureXyz.IsChecked = isChecked;
            cbFeatureWww.IsChecked = isChecked;
        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;

            var allChecked = 
                cbFeatureAbc.IsChecked == true && 
                cbFeatureXyz.IsChecked == true &&
                cbFeatureWww.IsChecked == true;

            if (allChecked)
                cbAllFeatures.IsChecked = true;

            var allUnchecked = 
                cbFeatureAbc.IsChecked == false &&
                cbFeatureXyz.IsChecked == false &&
                cbFeatureWww.IsChecked == false;

            if (allUnchecked)
                cbAllFeatures.IsChecked = false;
        }
    }
}
