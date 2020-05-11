using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WIMORepository.ViewModel.HelperViewModel
{
    class HelperViewModel : ViewModelProp
    {
        protected Model.WIMOEntities context = new Model.WIMOEntities();


        protected void ErrorMsgBox(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
