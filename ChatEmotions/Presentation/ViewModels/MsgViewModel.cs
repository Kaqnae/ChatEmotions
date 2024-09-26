using System.Collections.ObjectModel;
using System.Windows.Input;
using ChatEmotions.Domain;
using ChatEmotions.Presentation.Commands;

namespace ChatEmotions.Presentation.ViewModels;

public class MsgViewModel : Bindable
{
    public ICommand SearchCommand { get; }
    public ICommand RemoveCommand { get; }
    
    private ObservableCollection<MsgCollection> _msgCollection;
    public ObservableCollection<MsgCollection> MsgCollection
    {
        get => _msgCollection;
        set
        {
            _msgCollection = value;
            OnPropertyChanged();
        }
    }
    
    public Array EmotionsList => Enum.GetValues(typeof(Emotions));
    private Emotions _selectedEmotion;
    public Emotions SelectedEmotion
    {
        get => _selectedEmotion;
        set
        {
            _selectedEmotion = value;
            OnPropertyChanged();
        }
    }

    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            OnPropertyChanged();
        }
    }

    public MsgViewModel()
    {
        this.SearchCommand = new RelayCommand(SearchMessages, CanSearchMessages);
        this.RemoveCommand = new RelayCommand(RemoveMessages, CanRemoveMessages);
    }

    private void SearchMessages()
    {
        //implementation
    }

    private bool CanSearchMessages()
    {
        return _searchText != "";
    }

    private void RemoveMessages()
    {
        //implementation
    }

    private bool CanRemoveMessages()
    {
        return true;
        //need new implementation
    }
}