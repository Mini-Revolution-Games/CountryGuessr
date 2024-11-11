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
    /// Interaction logic for EU.xaml
    /// </summary>
    public partial class EU : Window
    {
        private Timer _timer;
        private Stopwatch Stopwatch = new Stopwatch();
        private const string StartTimeDisplay = "00:00:00";
        public int points = 0;
        public int ALLpoints = 47;
        public EU()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void End_Click(object sender, RoutedEventArgs e)
        {
            comp();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
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
            if (box == "albania")
            {
                if (albania.Visibility == Visibility.Hidden) {
                    Box.Clear();
                    albania.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "andora" || box == "andorra")
            {
                if (andora.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    andora.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "austria")
            {
                if (austria.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    austria.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "belgia" || box == "belgium")
            {
                if (belgia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    belgia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "białoruś" || box == "belarus")
            {
                if (bialorus.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    bialorus.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "bośnia" || box == "bosnia")
            {
                if (bosnia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    bosnia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "bułgaria" || box == "bulgaria")
            {
                if (bulgaria.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    bulgaria.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "chorwacja" || box == "croatia")
            {
                if (chorwacja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    chorwacja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "czarnogóra" || box == "montenegro")
            {
                if (czarnogora.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    czarnogora.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "czechy" || box == "czechia" || box == "czech republic")
            {
                if (czechy.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    czechy.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "dania" || box == "denmark")
            {
                if (dania.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    dania.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "estonia")
            {
                if (estonia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    estonia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "finlandia" || box == "finland")
            {
                if (finlandia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    finlandia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "francja" || box == "france")
            {
                if (francja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    francja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box  == "grecja" || box == "greece")
            {
                if (grecja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    grecja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "hiszpania" || box == "spain")
            {
                if (hiszpania.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    hiszpania.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "holandia" || box == "netherlands")
            {
                if (holandia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    holandia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "irlandia" || box == "ireland")
            {
                if (irlandia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    irlandia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "islandia" || box == "iceland")
            {
                if (islandia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    islandia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "kazachstan" || box == "kazakhstan")
            {
                if (kazachstan.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kazachstan.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "liechtenstein")
            {
                if (liechtenstein.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    liechtenstein.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "litwa" || box == "lithuania")
            {
                if (litwa.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    litwa.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "luksemburg" || box == "luxembourg")
            {
                if (luksemburg.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    luksemburg.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "łotwa" || box == "latvia")
            {
                if (lotwa.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    lotwa.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "macedonia" || box == "north macedonia")
            {
                if (macedonia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    macedonia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "malta")
            {
                if (malta.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    malta.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "mołdawia" || box == "moldova")
            {
                if (moldawia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    moldawia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "monako" || box == "monaco")
            {
                if (monako.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    monako.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "niemcy" || box == "germany")
            {
                if (niemcy.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    niemcy.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "norwegia" || box == "norway")
            {
                if (norwegia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    norwegia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "polska" || box == "poland")
            {
                if (polska.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    polska.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "portugalia" || box == "portugal")
            {
                if (portugalia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    portugalia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "rosja" || box == "russia")
            {
                if (rosja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    rosja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "rumunia" || box == "romania")
            {
                if (rumunia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    rumunia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "san marino")
            {
                if (sanmarino.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    sanmarino.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "serbia")
            {
                if (serbia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    serbia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "słowacja" || box == "slovakia")
            {
                if (slowacja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    slowacja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "słowenia" || box == "slovenia")
            {
                if (slowenia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    slowenia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "szwajcaria" || box == "switzerland")
            {
                if (szwajcaria.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    szwajcaria.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "szwecja" || box == "sweden")
            {
                if (szwecja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    szwecja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "turcja" || box == "turkey")
            {
                if (turcja.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    turcja.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "ukraina" || box == "ukraine")
            {
                if (ukraina.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ukraina.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "watykan" || box == "vatican")
            {
                if (watykan.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    watykan.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "węgry" || box == "hungary")
            {
                if (wegry.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    wegry.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "wielka brytania" || box == "uk" || box == "united kingdom")
            {
                if (uk.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    uk.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "włochy" || box == "italy")
            {
                if (wlochy.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    wlochy.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }

            }
            if (box == "kosowo" || box == "kosovo")
            {
                if (kosowo.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kosowo.Visibility = Visibility.Visible;
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
