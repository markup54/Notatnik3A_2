using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Notatnik3A
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

        private void MenuItem_Oprogramie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Notatnik do zapisywania informacji","Informacje o programie");
        }

        private void MenuItem_Oautorze_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autorem tego programu jest klasa 3A", "Informacje o autorze");
        }

        private void MenuItem_Nowy_Click(object sender, RoutedEventArgs e)
        {
            notatka_textbox.Text = "";
        }

        private void MenuItem_Otworz_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
        
            dialog.Filter = "Text documents (.txt)|*.txt";
            dialog.Title = "otwieranie pliku tekstowego";
            dialog.DefaultExt = ".txt";

            if(dialog.ShowDialog() == true)
            {
                string nazwaPliku = dialog.FileName;
                StreamReader plik = new StreamReader(nazwaPliku);
                string text = plik.ReadToEnd();
                plik.Close();
                notatka_textbox.Text = text;

            }
        }

        private void MenuItem_Zapiszjako_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text documenta(.txt) | *.txt";
            if(dialog.ShowDialog() == true)
            {
                string nazwaPliku = dialog.FileName;
                StreamWriter plik = new StreamWriter(nazwaPliku);
                plik.Write(notatka_textbox.Text);
                plik.Close() ;
            }
        }
    }
}
