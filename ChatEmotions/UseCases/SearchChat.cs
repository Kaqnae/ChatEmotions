using System.Collections.ObjectModel;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;

namespace ChatEmotions.UseCases;

public class SearchChat
{
    
    IXMLReader<MsgCollection> _reader;

    public SearchChat(IXMLReader<MsgCollection> reader)
    {
        this._reader = reader;
    }


    public ObservableCollection<MsgCollection> Action(string searchText)
    {
        ObservableCollection<MsgCollection> result = new();

        ObservableCollection<MsgCollection> allChatMsg = _reader.ReadAll();

        foreach (var msg in allChatMsg)
        {

            if (msg.Content.Contains(searchText))
            {
                result.Add(msg);
            }
        }
        
        return result;
    }


}