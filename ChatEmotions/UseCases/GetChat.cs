using System.Collections.ObjectModel;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;

namespace ChatEmotions.UseCases;

public class GetChat
{
    
    private IXMLReader<MsgCollection> _msgs;

    public GetChat(IXMLReader<MsgCollection> msgs)
    {
        this._msgs = msgs;
    }

    public ObservableCollection<MsgCollection> Action(Emotions emotions)
    {
        return _msgs.Read(emotions);
    }


}