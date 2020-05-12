using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WIMORepository.ViewModel.HelperViewModel;

namespace WIMORepository.ViewModel.PagesViewModels
{
    class LoginPageViewModel : WIMORepository.ViewModel.HelperViewModel.HelperViewModel
    {
        private string username = "";
        private string password = "";



        public string Username { 
            get => this.username; 
            set => Set<string>(ref username, value); 
        }

        public string Password
        {
            get => this.password;
            set => Set<string>(ref password, value);
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegistrationCommand { get; set; }



        public LoginPageViewModel()
        {
            this.LoginCommand = new Command(LoginCommandClick);
            this.RegistrationCommand = new Command(RegistrationCommandClick);
        }

        private void RegistrationCommandClick(object obj)
        {
            MessageBox.Show("Registration");
        }

        private void LoginCommandClick(object obj)
        {
            var res = base.context.Users.Where(i => i.Username == username);

            if (res.Count() > 0)
            {
                res = base.context.Users.Where(i => i.Username == username && i.Password == password);
                if (res.Count() > 0)
                {

                    int roleId = Convert.ToInt32(res.FirstOrDefault().IDRole);
                    switch (roleId)
                    {
                        case 1:
                            ViewModel.FuncWindowViewModel.FuncWindowViewModelClass.pageSideNum = 1;
                            break;

                        case 2:
                            ViewModel.FuncWindowViewModel.FuncWindowViewModelClass.pageSideNum = 0;
                            break;

                        case 3:
                            ViewModel.FuncWindowViewModel.FuncWindowViewModelClass.pageSideNum = 2;
                            break;

                        case 4:
                            ViewModel.FuncWindowViewModel.FuncWindowViewModelClass.pageSideNum = 3;
                            break;
                    }
                    ViewModel.AutorizationWindowViewModel.AutorizationWindowViewModelClass.OpenFuncWindow();
                }
                else
                {
                    ErrorMsgBox("Ошибка", "Вы неправильно ввели пароль.");
                }
            }
            else
            {
                ErrorMsgBox("Ошибка", "Вы неправильно ввели имя пользователя.");
            }
        }
    }
}
