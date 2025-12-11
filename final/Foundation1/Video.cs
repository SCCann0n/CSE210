public class Video
{
    string _title;

    string _author;

    int _length;

    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;

        _author = author;

        _length = length;
    }

    public int CommentAmount()
    {
        int totalCommentNum = comments.Count();
        return totalCommentNum;
    }

    public void AddComment(string name, string text)
    {
        Comment commentEntry = new Comment(name, text);

        comments.Add(commentEntry);
    }

    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}, {CommentAmount()}.");

        foreach (Comment c in comments)
        {
            c.CommentPrint();
        }
    }
}