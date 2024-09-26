using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChatEmotions.Presentation.ViewModels;

public class Bindable : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] String name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}