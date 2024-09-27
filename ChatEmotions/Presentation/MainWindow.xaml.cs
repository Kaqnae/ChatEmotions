using System.Windows;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;
using ChatEmotions.Presentation.ViewModels;

namespace ChatEmotions.Presentation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        //XMLAdapter xmlAdapter = new XMLAdapter();
        //xmlAdapter.Read(Emotions.Happy);
        //xmlAdapter.ReadAll();
        
        

        DataContext = new MsgViewModel();
        //hej noah
    }
}