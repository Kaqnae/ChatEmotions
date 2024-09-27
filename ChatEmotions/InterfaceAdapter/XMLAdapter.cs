
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Linq;
using ChatEmotions.Domain;

namespace ChatEmotions.InterfaceAdapter;

public class XMLAdapter : IXMLReader<MsgCollection>
{

    private string filePath = @"..\..\..\Persistence\XML files\";
    private ObservableCollection<MsgCollection> messageCollection = new ObservableCollection<MsgCollection>(); 
    
    public ObservableCollection<MsgCollection> Read(Enum emotion)
    {
        filePath = $"{filePath}{emotion}.xml";
        XElement xml = XElement.Load(filePath);
        var messages = (from msg in xml.Elements("message") select new MsgCollection(msg.Value)).ToList();

        foreach (var message in messages)
        {
            messageCollection.Add(message);
            Console.WriteLine(message);
        }
        return messageCollection;
    }

    public ObservableCollection<MsgCollection> ReadAll()
    {
        throw new NotImplementedException();
    }

    public void Update(MsgCollection input)
    {
        throw new NotImplementedException();
    }
}