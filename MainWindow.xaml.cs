using ReactiveUI_MemoryLeakTest_Wpf.ViewModels;

namespace ReactiveUI_MemoryLeakTest_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
