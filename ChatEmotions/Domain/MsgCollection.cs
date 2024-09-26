namespace ChatEmotions.Domain;

public class MsgCollection
{
    public string Content { get; set; }

    public override string ToString()
    {
        return Content;
    }

    public MsgCollection(string content)
    {
        Content = content;
    }
}