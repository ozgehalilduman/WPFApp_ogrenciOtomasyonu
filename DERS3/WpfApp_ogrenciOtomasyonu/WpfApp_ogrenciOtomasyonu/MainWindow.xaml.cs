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
        ogrenci secilen_ogr = new ogrenci();
        private void dataGrid_ogrler_Loaded(object sender, RoutedEventArgs e)
        {//dataGrid yüklendiğinde mevcut ogrenci listemi yüklüyorum...
            dataGrid_ogrler.ItemsSource = ogr.ogrenciListesi();
            CinsiyetComboBox.ItemsSource = ogr.cinsiyetListesi();
            comboBox_kayitislem_cinsiyet.ItemsSource= ogr.cinsiyetListesi();            
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

        private void kayit_sil(object sender, RoutedEventArgs e)
        {
            ogr.ogrenciSil(secilen_ogr);
            dataGrid_ogrler.Items.Refresh();
        }

        private void kayit_duzenle(object sender, RoutedEventArgs e)
        {
            lbl_kayitislem.Content = "KAYIT DÜZENLEME";
            dataGrid_ogrler.IsEnabled = false;
            StackPanel_kayitislem.Visibility = Visibility.Visible;
            StackPanel_kayitislem.DataContext = ogr.ogrenciListesi(secilen_ogr);
            /*
            ogrenci s_ogr= (ogrenci)dataGrid_ogrler.SelectedItem;
            textBox_okulno.Text = s_ogr.Okulno.ToString();
            textBox_ad.Text = s_ogr.Ad;
            textBox_soyad.Text = s_ogr.Soyad;
            textBox_sinif.Text = s_ogr.Sinif;
            textBox_tc.Text = s_ogr.TcNo;
            textBox_boy.Text = s_ogr.Boy.ToString();
            textBox_kilo.Text = s_ogr.Kilo.ToString();
            comboBox_kayitislem_cinsiyet.SelectedValue = s_ogr.Cinsiyet;
            */
        }

        private void btn_kayitislem_kapat_Click(object sender, RoutedEventArgs e)
        {
            StackPanel_kayitislem.Visibility = Visibility.Hidden;
            dataGrid_ogrler.IsEnabled = true;
        }

        private void ogrenci_kaydet_Click(object sender, RoutedEventArgs e)
        {
            /*
            ogrenci s_ogr = (ogrenci)dataGrid_ogrler.SelectedItem;
            s_ogr.Okulno = Int32.Parse(textBox_okulno.Text);
            s_ogr.Ad = textBox_ad.Text;
            s_ogr.Soyad = textBox_soyad.Text;
            s_ogr.Sinif= textBox_sinif.Text;
            s_ogr.TcNo = textBox_tc.Text;
            s_ogr.Boy = Convert.ToByte(textBox_boy.Text);
            s_ogr.Kilo = Convert.ToByte(textBox_kilo.Text);
            s_ogr.Cinsiyet = Convert.ToChar(comboBox_kayitislem_cinsiyet.SelectedValue);
            dataGrid_ogrler.Items.Refresh();
            */
            StackPanel_kayitislem.Visibility = Visibility.Hidden;
            dataGrid_ogrler.IsEnabled = true;
        }

        private void dataGrid_ogrler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            secilen_ogr = (ogrenci)dataGrid_ogrler.SelectedItem;
        }
    }
}
