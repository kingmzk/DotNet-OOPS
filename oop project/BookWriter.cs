public class BookWriter : Writer
{
    public BookWriter(string fname, string lname) : base(fname, lname)
    {
    }

    public override void vlog()
    {
         Console.WriteLine("i vlog using my iPHONE");
    }

    public override void writer()
    {
        
         Console.WriteLine("i vwrite BOOKS");
    }
}