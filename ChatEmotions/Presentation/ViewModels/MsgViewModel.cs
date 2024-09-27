using System.Collections.ObjectModel;
using System.Windows;
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
    private UpdateChat _updateChat;
    private SearchChat _searchChat;
    private CountSearch _countSearch;
    
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
    
    private MsgCollection _selectedMsg;

    public MsgCollection SelectedMsg
    {
        get => _selectedMsg;
        set
        {
            _selectedMsg = value;
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

    public MsgViewModel(IXMLReader<MsgCollection> msgReader)
    {
        this.SearchCommand = new RelayCommand(SearchMessages, CanSearchMessages);
        this.RemoveCommand = new RelayCommand(RemoveMessages, CanRemoveMessages);
        this.ShowMessagesCommand = new RelayCommand(ShowMessages, CanShowMessages);
        
        this._msgCollection = new ObservableCollection<MsgCollection>();
        
        this._getChat = new GetChat(msgReader);
        this._updateChat = new UpdateChat(msgReader);
        this._searchChat = new SearchChat(msgReader);
        this._countSearch = new CountSearch(msgReader);
    }

    private void ShowMessages()
    {
        this.MsgCollection.Clear();
        this.MsgCollection = _getChat.Action(_selectedEmotion);
    }

    private bool CanShowMessages()
    {
        return _selectedEmotion != null;
    }

    private void SearchMessages()
    {
        this.MsgCollection.Clear();
        this.MsgCollection = _searchChat.Action(_searchText);
        //KeyValuePair<Emotions, int> searchResult = _countSearch.Action(_searchText);
        
        //MessageBox.Show($"{_searchText} Appears: {searchResult.Value} times in {searchResult.Key}");



    }

    private bool CanSearchMessages()
    {
        return _searchText != "";
    }

    private void RemoveMessages()
    {
        this._msgCollection.Remove(_selectedMsg);
        this._updateChat.Action(_msgCollection, _selectedEmotion);
    }

    private bool CanRemoveMessages()
    {
        return _selectedEmotion != null;
    }
}