using System.Windows;

namespace WPF_LEARNING
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbHello.Text = "Hello World 2";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
