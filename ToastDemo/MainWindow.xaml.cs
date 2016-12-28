using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

            var checkedButton = RadioButtonPanel.Children.OfType<RadioButton>()
                                      .FirstOrDefault(r => (bool)(r.IsChecked));

            myToast.DurationToast = (Toast.Toast.ToastDuration)Enum.Parse(myToast.DurationToast.GetType(), checkedButton.Content as string);
        }
    }
}
