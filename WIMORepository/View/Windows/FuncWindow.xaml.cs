using System;
using System.Windows;
using System.Windows.Navigation;

namespace WIMORepository.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для FuncWindow.xaml
    /// </summary>
    public partial class FuncWindow : Window
    {
        public FuncWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel.FuncWindowViewModel.FuncWindowViewModelClass();
            ViewModel.FuncWindowViewModel.FuncWindowViewModelClass.CloseWindowMain = new Action(() => this.Close());
        }

    }
}
