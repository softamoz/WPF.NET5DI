using System.Windows;
using Microsoft.Extensions.Configuration;

namespace WPF.NET5DIAndConfiguration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IConfiguration configuration)
        {
            InitializeComponent();
            var connectionString = configuration.GetConnectionString("Default");
        }
    }
}