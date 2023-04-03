public class XSClubPromoter : Promoter ,IBodyBuilder,Ivlooger
{
    public XSClubPromoter(string fname, string lname, int cellphone) : base(fname, lname, cellphone)
    {
    }

    public void vlog()
    {
        
         Console.WriteLine("i am using DSLR to vlog");
    }

    public void WorkOut()
    {
        
         Console.WriteLine("i work out at my home");
    }

    protected override void ShareWithInnerCircle()
    {
        
         Console.WriteLine("i share with my instagram follower");
    }

    protected override void UsePaidAdd()
    {
      
         Console.WriteLine("i use Facebook ads");
    }
}