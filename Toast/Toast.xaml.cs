using System;
using System.Windows.Controls;

namespace Toast {
    /// <summary>
    /// Interaction logic for Toast.xaml
    /// </summary>
    public partial class Toast : UserControl {
        public string Message { get; set; } = "No Message set.";
        public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(2);


        public Toast() {
            InitializeComponent();
        }


        public void Show(string message, TimeSpan duration) {

        }


        public void Show() {
            Show(this.Message, this.Duration);
        }

        public void Show(string message) {
            Show(message, this.Duration);
        }

        public void Show(TimeSpan duration) {
            Show(this.Message, duration);
        }
    }
}
