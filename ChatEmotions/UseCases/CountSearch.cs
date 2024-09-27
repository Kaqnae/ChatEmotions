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

    public KeyValuePair<string, int> Action(string searchText)
    {
        _reader.ClearCollection();
        int finalCount = 0;
        string emotion = "";

        for (int i = 0; i < 4; i++)
        {
            _reader.ClearCollection();
            ObservableCollection<MsgCollection> msgCollection = _reader.Read((Emotions)i);
            int count = 0;

            foreach (var msg in msgCollection)
            {
                if (msg.Content.Contains(searchText))
                {
                    count++;
                }
            }
            
            if (count > finalCount)
            {
                emotion = (Emotions)i + "";
                finalCount = count;
            }
        }
        return new KeyValuePair<string, int>(emotion, finalCount);
    }
}