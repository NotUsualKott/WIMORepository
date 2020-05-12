using System.Windows.Input;
using System.Windows;
using WIMORepository.ViewModel.HelperViewModel;
using System;
using System.Windows.Controls;

namespace WIMORepository.ViewModel.AutorizationWindowViewModel
{
    class AutorizationWindowViewModelClass : WIMORepository.ViewModel.HelperViewModel.HelperViewModel
    {

        public static Action CloseAWindow { get; set; }

        private Page currentPage;

        public static int pageNum = 1;

        public Page CurrentPage
        {
            get => this.currentPage;
            set => this.Set<Page>(ref currentPage, value);
        }

        public ICommand ExitCommand { get; set; } //Команда для выхода


        public AutorizationWindowViewModelClass()
        {
            this.ExitCommand = new Command(ExitCommandClick);

            switch (pageNum)
            {
                case 0:
                    CurrentPage = new View.AutorizationWindowPages.RegistrationPage();
                    break;

                case 1:
                    CurrentPage = new View.AutorizationWindowPages.LoginPage();
                    break;

                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }

        private void ExitCommandClick(object obj)
        {
            Environment.Exit(0);
        }

        public static void OpenFuncWindow()
        {
            View.Windows.FuncWindow wind = new View.Windows.FuncWindow();
            wind.Show();
            CloseAWindow();
        }
    }
}
