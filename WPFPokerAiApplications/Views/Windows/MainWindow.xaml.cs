using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;


namespace WPFPokerAiApplications
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Событие Перерисовка формы
        private void Click_MainWindow( object sender , MouseButtonEventArgs e)
        {
            this.DragMove(); // Метод перерисовки
        }
        // Событие нажатия на кнопку Exit
        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        // Событие нажатия на кнопку Login
        private void Login_Click(object sender , RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.LoginPage());
        }
        // Событие нажатия на кнопку Account Data
        private void AccountData_Click(object sender , RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.AccountDataPage());
        }
        // Событие нажатия на кнопку Player Data
        private void PlayerData_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.PlayerDataPage());
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.NewsPage());
        }

        private void Tutorials_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TutorialsPage());
        }

        private void Table1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage1());
        }

        private void Table2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage2());
        }

        private void Table3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage3());
        }

        private void Table4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage4());
        }

        private void Table5_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage5());
        }

        private void Table6_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage6());
        }

        private void Table7_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage7());
        }

        private void Table8_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Views.Windows.Pages.TablePage8());
        }


    }
}
