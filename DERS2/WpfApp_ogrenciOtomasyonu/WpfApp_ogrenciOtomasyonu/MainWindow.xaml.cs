using System;
using System.Collections;
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
        private void btn_ayar_kapat_Click(object sender, RoutedEventArgs e)
        {
            StackPanel_ayarlar.Visibility = Visibility.Hidden;
        }

        private void btn_ayarlar_Click(object sender, RoutedEventArgs e)
        {
            StackPanel_ayarlar.Visibility = Visibility.Visible;
        }

        private void checkBox_sorting_Checked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserSortColumns = true;            
        }

        private void checkBox_sorting_Unchecked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserSortColumns = false;
        }

        private void checkBox_resizecolumn_Checked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserResizeColumns = true;
        }

        private void checkBox_resizerow_Checked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserResizeRows = true;
        }

        private void checkBox_reorder_Checked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserReorderColumns = true;
        }

        private void checkBox_resizecolumn_Unchecked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserResizeColumns = false;
        }

        private void checkBox_resizerow_Unchecked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserResizeRows = false;
        }

        private void checkBox_reorder_Unchecked(object sender, RoutedEventArgs e)
        {
            dataGrid_ogrler.CanUserReorderColumns = false;
        }

        private void dataGrid_ogrler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            

        }

        private void kayit_sil(object sender, RoutedEventArgs e)
        {
            ogrenci secilen_ogr = (ogrenci)dataGrid_ogrler.SelectedItem;
            ogr.ogrenciSil(secilen_ogr);
            dataGrid_ogrler.Items.Refresh();
        }

        private void kayit_duzenle(object sender, RoutedEventArgs e)
        {
            lbl_kayitislem.Content = "KAYIT DÜZENLEME";
            dataGrid_ogrler.IsEnabled = false;
            StackPanel_kayitislem.Visibility = Visibility.Visible;

        }

        private void btn_kayitislem_kapat_Click(object sender, RoutedEventArgs e)
        {
            StackPanel_kayitislem.Visibility = Visibility.Hidden;
            dataGrid_ogrler.IsEnabled = true;
        }
    }
}
