using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Timer = System.Timers.Timer;

namespace CountryGuessr
{
    /// <summary>
    /// Interaction logic for OC.xaml
    /// </summary>
    /// 
    public partial class OC : Window
    {
        private Timer _timer;
        private Stopwatch Stopwatch = new Stopwatch();
        private const string StartTimeDisplay = "00:00:00";
        public int points = 0;
        public int ALLpoints = 14;
        public OC()
        {
            InitializeComponent();
            TimerDisplay.Content = StartTimeDisplay;
            _timer = new Timer(interval: 1000);
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => TimerDisplay.Content = Stopwatch.Elapsed.ToString(format: @"hh\:mm\:ss"));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PointsText.Text = points + "/" + ALLpoints;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (Box.Visibility == Visibility.Visible)
            {
                Box.Visibility = Visibility.Hidden;
                Start.Background = Brushes.LimeGreen;
                Start.Content = "START";
                Stopwatch.Stop();
                _timer.Stop();
            }
            else
            {
                Box.Visibility = Visibility.Visible;
                Start.Background = Brushes.Red;
                Start.Content = "STOP";
                Stopwatch.Start();
                _timer.Start();
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            comp();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            string boxNorm = Box.Text;
            string box = boxNorm.ToLower();
            if (box == "australia")
            {
                if(AU.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    AU.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "nowa zelandia" || box == "new zealand")
            {
                if (NZ.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    NZ.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "fidżi" || box == "fiji")
            {
                if (Fiji.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Fiji.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "papua nowa gwinea" || box == "papua new guinea" || box == "png")
            {
                if (PNG.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    PNG.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "solomon islands" || box == "wyspy salomona")
            {
                if (Salomon.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Salomon.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "vanuatu")
            {
                if (Vanuatu.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Vanuatu.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "mikronezja" || box == "micronesia")
            {
                if (Micro.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Micro.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "kiribati")
            {
                if (Kiribati.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Kiribati.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "wyspy marshalla" || box == "marshall islands")
            {
                if (marshal.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    marshal.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "nauru")
            {
                if (Nauru.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Nauru.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "palau")
            {
                if (Palau.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Palau.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "samoa")
            {
                if (Samoa.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Samoa.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "tonga")
            {
                if (Tonga.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Tonga.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "tuvalu")
            {
                if (Tuvalu.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Tuvalu.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
        }

        private void comp()
        {
            if (MainWindow.PL_True_ENG_False == false)
            {
                Stopwatch.Stop();
                _timer.Stop();
                MessageBox.Show("congratulations you scored " + points + "/" + ALLpoints + " points. you did it in " + TimerDisplay.Content
                    + " Click OK to go to the main window");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else if (MainWindow.PL_True_ENG_False == true)
            {
                Stopwatch.Stop();
                _timer.Stop();
                MessageBox.Show("GRATULACJE ZDOBYŁEŚ " + points + "/" + ALLpoints + " punktów. zrobiłeś to w czasie " + TimerDisplay.Content
                    + " Kliknij OK aby przejść do okna głównego");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }


    }
}
