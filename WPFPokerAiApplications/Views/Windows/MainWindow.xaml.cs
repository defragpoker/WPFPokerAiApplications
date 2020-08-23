using System.Windows;
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
    }
}
