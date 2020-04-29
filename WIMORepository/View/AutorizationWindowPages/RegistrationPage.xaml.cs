using System.Windows;
using System.Windows.Controls;


namespace WIMORepository.View.AutorizationWindowPages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            DataContext = new ViewModel.FuncWindowViewModel.FuncWindowViewModelClass();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
