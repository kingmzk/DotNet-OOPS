public class OnmiaClubPromoter : Promoter
{
    public OnmiaClubPromoter(string fname, string lname, int cellphone) : base(fname, lname, cellphone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
       
         Console.WriteLine("i Share with my friends");
    }

    protected override void UsePaidAdd()
    {
        
         Console.WriteLine("i use Google ads");
    }
}