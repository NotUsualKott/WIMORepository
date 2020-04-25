using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
        }
    }
}
