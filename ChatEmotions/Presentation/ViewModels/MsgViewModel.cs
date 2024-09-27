using System.Collections.ObjectModel;
using System.Windows.Input;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;
using ChatEmotions.Presentation.Commands;
using ChatEmotions.UseCases;

namespace ChatEmotions.Presentation.ViewModels;

public class MsgViewModel : Bindable
{
    public ICommand ShowMessagesCommand { get; }
    
    public ICommand SearchCommand { get; }
    public ICommand RemoveCommand { get; }
    
    private GetChat _getChat;
    
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

    public MsgViewModel(IXMLReader<MsgCollection> msgCollection)
    {
        this.SearchCommand = new RelayCommand(SearchMessages, CanSearchMessages);
        this.RemoveCommand = new RelayCommand(RemoveMessages, CanRemoveMessages);
        this.ShowMessagesCommand = new RelayCommand(ShowMessages, CanShowMessages);
        this._getChat = new GetChat(msgCollection);
        this._msgCollection = new ObservableCollection<MsgCollection>();
        
    }

    private void ShowMessages()
    {

        this.MsgCollection = _getChat.Action(_selectedEmotion);
        Console.WriteLine("Success");
    }

    private bool CanShowMessages()
    {
        return _selectedEmotion != null;
    }

    private void SearchMessages()
    {
        
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