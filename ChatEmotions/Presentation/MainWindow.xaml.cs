using System.Windows;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;

namespace ChatEmotions.Presentation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        XMLAdapter xmlAdapter = new XMLAdapter();
        xmlAdapter.Read(Emotions.Happy);
        //hej noah
    }
}