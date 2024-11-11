using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Globalization;

namespace CountryGuessr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool PL_True_ENG_False;
        public MainWindow()
        {
            InitializeComponent();
            SetLang(Properties.Settings.Default.lang);
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

        private void Play(object sender, RoutedEventArgs e)
        {
            Wojewodztwa wojewodztwa = new Wojewodztwa();
            wojewodztwa.Show();
            this.Close();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SA sA = new SA();
            sA.Show();
            this.Close();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EU eU = new EU();
            eU.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CapitalsOfEU capitalsOfEU = new CapitalsOfEU();
            capitalsOfEU.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OC oc = new OC();
            oc.Show();
            this.Close();
        }


        private void Click_Categories(object sender, RoutedEventArgs e)
        {
            Categories.Visibility = Visibility.Visible;
            GAMES.Visibility = Visibility.Hidden;
            panstwa.Visibility = Visibility.Hidden;
            podzial.Visibility = Visibility.Hidden;
            stolice.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            if(PL_True_ENG_False == true)
            {
                Title.Text = "Kategorie";
            }
            else
            {
                Title.Text = "Categories";
            }

        }

        private void Click_games(object sender, RoutedEventArgs e)
        {
            Categories.Visibility = Visibility.Hidden;
            GAMES.Visibility = Visibility.Visible;
            panstwa.Visibility = Visibility.Hidden;
            podzial.Visibility = Visibility.Hidden;
            stolice.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            if (PL_True_ENG_False == true)
            {
                Title.Text = "Gry";
            }
            else
            {
                Title.Text = "Games";
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Categories.Visibility = Visibility.Hidden;
            GAMES.Visibility = Visibility.Hidden;
            panstwa.Visibility = Visibility.Visible;
            podzial.Visibility = Visibility.Hidden;
            stolice.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            if (PL_True_ENG_False == true)
            {
                Title.Text = "Państwa";
            }
            else
            {
                Title.Text = "Countries";
            }
        }

        private void PA_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Categories.Visibility = Visibility.Hidden;
            GAMES.Visibility = Visibility.Hidden;
            panstwa.Visibility = Visibility.Hidden;
            podzial.Visibility = Visibility.Visible;
            stolice.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            if (PL_True_ENG_False == true)
            {
                Title.Text = "Podział administracyjny";
            }
            else
            {
                Title.Text = "Administrative division";
            }
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Categories.Visibility = Visibility.Hidden;
            GAMES.Visibility = Visibility.Hidden;
            panstwa.Visibility = Visibility.Hidden;
            podzial.Visibility = Visibility.Hidden;
            stolice.Visibility = Visibility.Visible;
            settings.Visibility = Visibility.Hidden;
            if (PL_True_ENG_False == true)
            {
                Title.Text = "Stolice i miasta";
            }
            else
            {
                Title.Text = "Capitals and Cities";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Categories.Visibility = Visibility.Hidden;
            GAMES.Visibility = Visibility.Hidden;
            panstwa.Visibility = Visibility.Hidden;
            podzial.Visibility = Visibility.Hidden;
            stolice.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Visible;
            if (PL_True_ENG_False == true)
            {
                Title.Text = "Ustawienia";
            }
            else
            {
                Title.Text = "Settings";
            }
        }

        private void english_Click(object sender, RoutedEventArgs e)
        {
            SetLang(((Button)sender).Tag.ToString());
        }

        private void SetLang(string lang)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            Application.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary resdict = new ResourceDictionary()
            {
                Source = new Uri($"/Dictionary_{lang}.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(resdict);
            english.IsEnabled = true;
            polish.IsEnabled = true;

            switch(lang)
            {
                case "eng":
                    english.IsEnabled = false;
                    PL_True_ENG_False = false;
                    break;
                case "PL":
                    polish.IsEnabled = false;
                    PL_True_ENG_False = true;
                    break;
                default: break;
            }

            Properties.Settings.Default.lang = lang;
            Properties.Settings.Default.Save();
        }


    }
}