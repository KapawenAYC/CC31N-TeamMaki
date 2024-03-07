using Engine.View_Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC31N_TeamMaki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Game_Session _gameSession;
    public MainWindow()
    {
        InitializeComponent();
        _gameSession = new Game_Session();
        DataContext = _gameSession;

    }
}