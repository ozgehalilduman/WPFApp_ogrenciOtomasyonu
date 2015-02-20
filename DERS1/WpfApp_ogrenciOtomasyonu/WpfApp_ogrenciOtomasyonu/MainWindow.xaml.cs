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

namespace WpfApp_ogrenciOtomasyonu
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
        
        ogrenci_islemleri ogr = new ogrenci_islemleri();
        private void dataGrid_ogrler_Loaded(object sender, RoutedEventArgs e)
        {//dataGrid yüklendiğinde mevcut ogrenci listemi yüklüyorum...
            dataGrid_ogrler.ItemsSource = ogr.ogrenciListesi();
            CinsiyetComboBox.ItemsSource = ogr.cinsiyetListesi();
        }

    }
}
