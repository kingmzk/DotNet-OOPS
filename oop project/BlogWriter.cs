public class BlogWriter : Writer
{
    public BlogWriter(string fname , string lname) : base(fname , lname)
    {
    }

    public override void vlog()
    {
        Console.WriteLine("i vlog using GOPRO");
    }

    public override void writer()
    {
         Console.WriteLine("i am writing for my own blog");
    }
}