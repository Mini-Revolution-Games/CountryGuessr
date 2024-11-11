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
    /// Interaction logic for SA.xaml
    /// </summary>
    public partial class SA : Window
    {
        private Timer _timer;
        private Stopwatch Stopwatch = new Stopwatch();
        private const string StartTimeDisplay = "00:00:00";
        public int points = 0;
        public int ALLpoints = 12;
        public SA()
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            string boxNorm = Box.Text;
            string box = boxNorm.ToLower();
            if (box == "argentyna" || box == "argentina")
            {
                if (argentyna.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    argentyna.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "boliwia" || box == "bolivia")
            {
                if (boliwia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    boliwia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "brazylia" || box == "brazil")
            {
                if (brazil.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    brazil.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "chile")
            {
                if (chile.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    chile.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "ekwador" || box == "ecuador")
            {
                if (ekwador.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ekwador.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "gujana" || box == "guyana")
            {
                if (gujana.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    gujana.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "kolumbia" || box == "colombia")
            {
                if (kolumbia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kolumbia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "paragwaj" || box == "paraguay")
            {
                if (paragwaj.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    paragwaj.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "peru")
            {
                if (peru.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    peru.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "surinam" || box == "suriname")
            {
                if (surinam.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    surinam.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "urugwaj" || box == "uruguay")
            {
                if (urugwaj.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    urugwaj.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }

                }

            }
            if (box == "wenezuela" || box == "venezuela")
            {
                if (wenezuela.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    wenezuela.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
        }
    }
}
