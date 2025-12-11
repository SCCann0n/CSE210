using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> vList = new List<Video>();

        Video v1 = new Video("iPhone unboxing", "UnboxTherapy", 20 );
        v1.AddComment("user1", "Comment1");
        v1.AddComment("user2", "Comment2");
        v1.AddComment("user3", "Comment3");
        
        Video v2 = new Video("Samsung unboxing", "UnboxTherapy", 18 );
        v2.AddComment("user1", "Comment1");
        v2.AddComment("user2", "Comment2");
        v2.AddComment("user3", "Comment3");

        Video v3 = new Video("Pixel unboxing", "UnboxTherapy", 19 ); 
        v3.AddComment("user1", "Comment1");
        v3.AddComment("user2", "Comment2");
        v3.AddComment("user3", "Comment3");

        vList.Add(v1);
        vList.Add(v2);
        vList.Add(v3);

        foreach (Video v in vList)
        {
            v.Display();
        }
    }
}