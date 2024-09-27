using System.Collections.ObjectModel;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;

namespace ChatEmotions.UseCases;

public class CountSearch
{

    private IXMLReader<MsgCollection> _reader;

    public CountSearch(IXMLReader<MsgCollection> reader)
    {
        this._reader = reader;
    }

    public KeyValuePair<Emotions, int> Action(string searchText)
    {
     
        Dictionary<Emotions, ObservableCollection<MsgCollection>> chatMsgCollections = new();
        Dictionary<Emotions, int> emotionWordCount = new();

        for (int i = 0; i < 4; i++)
        {
            chatMsgCollections.Add((Emotions)i, _reader.Read((Emotions)i));
        }

        foreach (var chat in chatMsgCollections)
        {
            foreach (var msg in chat.Value)
            {
                int count = 0;
                
                if (msg.Content.Contains(searchText))
                {
                    count++;
                }
                emotionWordCount.Add(chat.Key, count);
            }
        }
        KeyValuePair<Emotions, int> result = emotionWordCount.OrderByDescending(x => x.Value).First();
        
        return result;
    }


}