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
using System.Windows.Forms;
using ResolutionChanger.Classes;

namespace ResolutionChanger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string BaseFolderPath;
        private string SaveFolderPath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BaseFolderButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BaseFolderTextBox.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        private void SaveFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveFolderTextBox.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        private void BaseFolderTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            BaseFolderPath = (sender as System.Windows.Controls.TextBox).Text;
            StartEditButton.IsEnabled = (BaseFolderPath?.Length > 0 && SaveFolderPath?.Length > 0) ? true : false;
        }

        private void SaveFolderTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveFolderPath = (sender as System.Windows.Controls.TextBox).Text;
            StartEditButton.IsEnabled =(BaseFolderPath?.Length > 0 && SaveFolderPath?.Length > 0) ? true : false;
        }
        private bool isComboBoxTextCorrect()
        {
            string buf = DisplayFormatComboBox.Text;
            ushort a;
            return buf.Contains(':') && UInt16.TryParse(buf.Split(':')[0], out a) && UInt16.TryParse(buf.Split(':')[1], out a);
        }
    }
}
