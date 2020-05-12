using System.Windows;
using System.Windows.Input;
using WIMORepository.ViewModel.HelperViewModel;
using WIMORepository.View.AutorizationWindowPages;
     

namespace WIMORepository.ViewModel.PagesViewModels
{
    class RegistrationPageViewModel : WIMORepository.ViewModel.HelperViewModel.HelperViewModel
    {
        public ICommand PersDataCommand { get; set; }
        public ICommand AgreeCommand { get; set; }

        RegistrationPage registrationPage = new RegistrationPage();

        public RegistrationPageViewModel()
        {
            ///this.PersDataCommand = new Command(PersDataClick);
            this.AgreeCommand = new Command(AgreeClick);
        }

        public void PersonalData_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AgreeClick(object obj)
        {
            MessageBox.Show("Логин");

        }
    }
}
