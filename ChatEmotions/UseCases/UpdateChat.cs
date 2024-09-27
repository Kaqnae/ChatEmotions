using System.Collections.ObjectModel;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;

namespace ChatEmotions.UseCases;

public class UpdateChat
{
    private IXMLReader<MsgCollection> _msgs;

    public UpdateChat(IXMLReader<MsgCollection> msgs)
    {
        this._msgs = msgs;
    }

    public void Action(ObservableCollection<MsgCollection> msgs, Emotions emotions)
    {
        _msgs.Update(msgs, emotions);
    }
}