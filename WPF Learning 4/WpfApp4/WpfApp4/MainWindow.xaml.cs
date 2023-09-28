using Microsoft.Win32;
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

namespace WpfApp4
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.Filter = "C# Source files | *.cs";
            fileDialog.Title = "Please pick a CS Source File...";
fileDialog.Multiselect = true;
            bool? succes=fileDialog.ShowDialog();
            if(succes==true)
            {
                string[] paths=fileDialog.FileNames;
                string[]filenames=fileDialog.SafeFileNames;

                //tbInfo.Text = filename;

            }
            else 
            {
            
            }

        }
    }
}
