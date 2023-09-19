using System.Windows;

namespace WPF_LEARNING
{

    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

       
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running) 
            {
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else 
            {
             tbStatus.Text = "Runnig";
                btnToggleRun.Content = "Stop";
            }

            running = !running;
        }
    }
}
