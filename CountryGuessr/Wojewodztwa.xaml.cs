using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
//using System.Windows.Threading;

namespace CountryGuessr
{
    /// <summary>
    /// Interaction logic for Wojewodztwa.xaml
    /// </summary>
    public partial class Wojewodztwa : Window
    {
        private Timer _timer;
        private Stopwatch Stopwatch = new Stopwatch();
        private const string StartTimeDisplay = "00:00:00";
        public int points = 0;
        public int ALLpoints = 16;
        public Wojewodztwa()
        {
            InitializeComponent();
            TimerDisplay.Content = StartTimeDisplay;
            _timer = new Timer(interval:1000);
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => TimerDisplay.Content = Stopwatch.Elapsed.ToString(format:@"hh\:mm\:ss"));
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if(Box.Visibility == Visibility.Visible)
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PointsText.Text = points + "/" + ALLpoints;
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

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            string boxNorm = Box.Text;
            string box = boxNorm.ToLower();
            if (box == "podkarpacie" || box == "podkarpackie" || box == "subcarpathian")
            {
                if (PODK.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    PODK.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "małopolskie" || box == "lesser poland")
            {
                if (MAPOL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    MAPOL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "zachodniopomorskie" || box == "west pomeranian")
            {
                if (ZACHPOM.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ZACHPOM.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "pomorskie" || box == "pomeranian")
            {
                if (POM.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    POM.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "wielkopolskie" || box == "greater poland")
            {
                if (WIELKOPOL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    WIELKOPOL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "warmińsko mazurskie" || box == "warmińsko-mazurskie" || box == "warmian-masurian" || box == "warmian masurian")
            {
                if (WARMAZ.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    WARMAZ.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "świętokrzyskie" || box == "holy cross")
            {
                if (ŚwKrz.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ŚwKrz.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "śląskie" || box == "silesian")
            {
                if (ŚL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ŚL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "dolnośląskie" || box == "lower silesian" || box == "lowersilesian")
            {
                if (DOLŚL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    DOLŚL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "podlaskie" || box == "podlasie")
            {
                if (PODL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    PODL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "opolskie" || box == "opole")
            {
                if (OPOL.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    OPOL.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "mazowieckie" || box == "masovian" || box == "mazowsze")
            {
                if (MAZ.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    MAZ.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "łódzkie" || box == "łódź" || box == "lodz" || box == "lodzkie")
            {
                if (ŁÓDZ.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ŁÓDZ.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "lubuskie" || box == "lubusz")
            {
                if (LUBUS.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    LUBUS.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "lubelskie" || box == "lublin")
            {
                if (LUBE.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    LUBE.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }
            else if (box == "kujawsko pomorskie" || box == "kujawsko-pomorskie" || box == "kuyavian-pomeranian" || box == "kuyavian pomeranian")
            {
                if (KUJPOM.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    KUJPOM.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == 16)
                    {
                        comp();
                    }
                }

            }

        }
        private void End_Click(object sender, RoutedEventArgs e)
        {
            comp();
        }
        private void comp()
        {
            if(MainWindow.PL_True_ENG_False == false)
            {
                Stopwatch.Stop();
                _timer.Stop();
                MessageBox.Show("congratulations you scored " + points + "/" + ALLpoints + " points. you did it in " + TimerDisplay.Content
                    + " Click OK to go to the main window");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else if(MainWindow.PL_True_ENG_False == true)
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
