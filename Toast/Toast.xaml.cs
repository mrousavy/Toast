using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Toast {
    /// <summary>
    /// Interaction logic for Toast.xaml
    /// </summary>
    public partial class Toast : UserControl {


        //User-Changeable Values
        public string Message { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(2);
        public TimeSpan DurationAnimation { set; get; } = TimeSpan.FromMilliseconds(300);
        public ToastDuration DurationToast {
            set {

                _internalDurationToast = value;
            }
            get {
                return _internalDurationToast;
            }
        }

        public new object Content {
            set {
                Message = value as string;
            }
            get {
                return Message;
            }
        }


        public enum ToastDuration { Short, Medium, Long }
        private ToastDuration _internalDurationToast;



        public Toast() {
            InitializeComponent();
        }


        public void Show(string message, TimeSpan duration) {
            ToastContent.Text = message;

            DoubleAnimation anim = new DoubleAnimation(this.Opacity, 1d, this.DurationAnimation);

            anim.Completed += async delegate {
                await Task.Delay(this.Duration);
                Hide();
            };

            this.BeginAnimation(UserControl.OpacityProperty, anim);
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

        public void Show(ToastDuration duration) {
            Show(this.Message, ToastDurationToTimeSpan(duration));
        }


        public void Hide() {
            DoubleAnimation anim = new DoubleAnimation(this.Opacity, 0d, this.DurationAnimation);
            this.BeginAnimation(UserControl.OpacityProperty, anim);
        }


        private TimeSpan ToastDurationToTimeSpan(ToastDuration tduration) {
            TimeSpan ret = Duration;

            switch(tduration) {
                case ToastDuration.Short:
                    ret = TimeSpan.FromSeconds(2);
                    break;
                case ToastDuration.Medium:
                    ret = TimeSpan.FromSeconds(5);
                    break;
                case ToastDuration.Long:
                    ret = TimeSpan.FromSeconds(10);
                    break;
            }


            return ret;
        }
    }
}
