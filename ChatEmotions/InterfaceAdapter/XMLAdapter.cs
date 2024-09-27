
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
        string xfilePath = $"{filePath}{emotion}.xml";
        XElement xml = XElement.Load(xfilePath);
        var messages = (from msg in xml.Elements("message") select new MsgCollection(msg.Value)).ToList();

        foreach (var message in messages)
        {
            messageCollection.Add(message);
            //Console.WriteLine(message);
        }
        return messageCollection;
    }

    public ObservableCollection<MsgCollection> ReadAll()
    {
        int numOfFiles = Directory.GetFiles(filePath).Length;
        Console.WriteLine($"number of files: {numOfFiles}");
        
        
        for (int i = 0; i < numOfFiles; i++)
        {
            Read((Emotions)i);
        }
        Console.WriteLine(messageCollection.Count);
        return messageCollection;
    }

   

    public void Update(ObservableCollection<MsgCollection> input, Enum emotion)
    {
        
    }
}