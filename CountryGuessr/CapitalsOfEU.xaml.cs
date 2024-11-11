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
    /// Interaction logic for CapitalsOfEU.xaml
    /// </summary>
    public partial class CapitalsOfEU : Window
    {
        private Timer _timer;
        private Stopwatch Stopwatch = new Stopwatch();
        private const string StartTimeDisplay = "00:00:00";
        public int points = 0;
        public int ALLpoints = 44;
        public CapitalsOfEU()
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PointsText.Text = points + "/" + ALLpoints;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
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

        private void End_Click(object sender, RoutedEventArgs e)
        {
            comp();
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            string boxNorm = Box.Text;
            string box = boxNorm.ToLower();
            if (box == "valletta")
            {
                if (Valletta.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Valletta.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "amsterdam")
            {
                if (Amsterdam.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Amsterdam.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "andora" || box == "andorra la vella" || box == "andorra")
            {
                if (Andora.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Andora.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "ateny" || box == "athens")
            {
                if (Ateny.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Ateny.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "belgrad" || box == "belgrade")
            {
                if (Belgrad.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Belgrad.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "berlin")
            {
                if (Berlin.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Berlin.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "berno" || box == "bern")
            {
                if (Berno.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Berno.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "bratysława" || box == "bratislava")
            {
                if (Bratysława.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Bratysława.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "bruksela" || box == "brussels")
            {
                if (Bruksela.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Bruksela.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "budapeszt" || box == "budapest")
            {
                if (budapeszt.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    budapeszt.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "bukareszt" || box == "bucharest")
            {
                if (bukareszt.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    bukareszt.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "dublin")
            {
                if (dublin.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    dublin.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "helsinki")
            {
                if (helsinki.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    helsinki.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "kijów" || box == "kyiv")
            {
                if (kijów.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kijów.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "kiszynów" || box == "chișinău" || box == "chisinau")
            {
                if (kiszynów.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kiszynów.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "kopenhaga" || box == "copenhagen")
            {
                if (kopenhaga.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    kopenhaga.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "lizbona" || box == "lisbon")
            {
                if (lizbona.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    lizbona.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "londyn" || box == "london")
            {
                if (londyn.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    londyn.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "lublana" || box == "ljubljana")
            {
                if (lublana.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    lublana.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "madryt" || box == "madrid")
            {
                if (madrid.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    madrid.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "mińsk" || box == "minsk")
            {
                if (minsk.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    minsk.Visibility = Visibility.Visible;
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
            if (box == "moskwa" || box == "moscow")
            {
                if (moskwa.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    moskwa.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "oslo")
            {
                if (oslo.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    oslo.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "paryż" || box == "paris")
            {
                if (paryz.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    paryz.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "podgorica")
            {
                if (podgorica.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    podgorica.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "praga" || box == "prague")
            {
                if (praga.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    praga.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "prisztina" || box == "pristina")
            {
                if (prisztina.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    prisztina.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "reykjavik")
            {
                if (reykjavik.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    reykjavik.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "ryga" || box == "riga")
            {
                if (ryga.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    ryga.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "rzym" || box == "rome")
            {
                if (rzym.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    rzym.Visibility = Visibility.Visible;
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
            if (box == "sarajewo" || box == "sarajevo")
            {
                if (sarajewo.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    sarajewo.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "skopje")
            {
                if (skopje.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    skopje.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "sofia")
            {
                if (sofia.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    sofia.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "sztokholm" || box == "stockholm")
            {
                if (sztokholm.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    sztokholm.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "tirana")
            {
                if (Tirana.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Tirana.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "vaduz")
            {
                if (Vaduz.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Vaduz.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "warszawa" || box == "warsaw")
            {
                if (Warszawa.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    Warszawa.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "wiedeń" || box == "vienna")
            {
                if (wieden.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    wieden.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "wilno" || box == "vilnius")
            {
                if (wilno.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    wilno.Visibility = Visibility.Visible;
                    points++;
                    PointsText.Text = points + "/" + ALLpoints;
                    if (points == ALLpoints)
                    {
                        comp();
                    }
                }
            }
            if (box == "zagrzeb" || box == "zagreb")
            {
                if (zagrzeb.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    zagrzeb.Visibility = Visibility.Visible;
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
            if (box == "tallin" || box == "tallinn")
            {
                if (tallin.Visibility == Visibility.Hidden)
                {
                    Box.Clear();
                    tallin.Visibility = Visibility.Visible;
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
