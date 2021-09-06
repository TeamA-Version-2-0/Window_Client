
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModelClient viewmodel = new ViewModelClient();
            DataContext = viewmodel;
            datagrid1.ItemsSource = viewmodel.Blacklist;
        }
    }
}
