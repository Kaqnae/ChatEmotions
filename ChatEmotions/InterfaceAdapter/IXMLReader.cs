using System.Collections.ObjectModel;

namespace ChatEmotions.InterfaceAdapter;

public interface IXMLReader<T>
{
    ObservableCollection<T> Read(Enum emotion);
    List<T> ReadAll();
    void Update(T input);
}