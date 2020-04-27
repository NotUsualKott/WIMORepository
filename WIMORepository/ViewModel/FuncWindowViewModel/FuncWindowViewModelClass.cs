using System.Windows.Input;
using System.Windows;
using WIMORepository.ViewModel.HelperViewModel;
using System;
using System.Windows.Controls;
using WIMORepository.View.FuncWindowPages.FuncButtonPages;



namespace WIMORepository.ViewModel.FuncWindowViewModel
{
    class FuncWindowViewModelClass : ViewModel.HelperViewModel.HelperViewModel
    {
        public static Action CloseWindowMain { get; set; }

        private Page currentCenterPage;
        private Page currentSidePage;

        public static int pageCenterNum  { get; set; }
        public static int pageSideNum { get; set; }

        public ICommand ExitCommand { get; set; }
        public ICommand OpenProfileCommand { get; set; }

        public Page CurrentCenterPage
        {
            get => this.currentCenterPage;
            set => this.Set<Page>(ref currentCenterPage, value);
        }

        public Page CurrentSidePage
        {
            get => this.currentSidePage;
            set => this.Set<Page>(ref currentSidePage, value);
        }

        public FuncWindowViewModelClass()
        {
            

            this.ExitCommand = new Command(FuncExitCommandClick);
            this.OpenProfileCommand = new Command(FuncOpenProfileCommandClick);


            switch (pageCenterNum)
            {
                default:
                    CurrentCenterPage = new View.FuncWindowPages.TestPage();
                    break;

                case 1:
                    CurrentCenterPage = new View.FuncWindowPages.FuncCenterPages.ProfilePage();
                    break;
                
            }


            switch (pageSideNum)
            {
                case 0:
                    CurrentSidePage = new View.FuncWindowPages.FuncButtonPages.AdminPage();
                    break;
                case 1:
                    CurrentSidePage = new View.FuncWindowPages.FuncButtonPages.AgentPage();
                    break;
                case 2:
                    CurrentSidePage = new View.FuncWindowPages.FuncButtonPages.ManagerPage();
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }

        

        private void FuncExitCommandClick(object obj)
        {
            Environment.Exit(0);
        }

        private void FuncOpenProfileCommandClick(object obj)
        {
            pageCenterNum = 1;
        }
    }

    
}