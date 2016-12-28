using System.Windows;

namespace ToastDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ShowToastClick(object sender, RoutedEventArgs e) {
            InitToast();
            myToast.Show();
        }

        private void HideToastClick(object sender, RoutedEventArgs e) {
            myToast.Hide();
        }

        private void InitToast() {
            myToast.Content = ToastNameBox.Text;

            Toast.Toast.ToastDuration duration = Toast.Toast.ToastDuration.Short;

            if(MediumRadio.IsChecked == true)
                duration = Toast.Toast.ToastDuration.Medium;
            if(LongRadio.IsChecked == true)
                duration = Toast.Toast.ToastDuration.Long;

            myToast.DurationToast = duration;
        }
    }
}
