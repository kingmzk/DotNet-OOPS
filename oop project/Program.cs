using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>()   {new XSClubPromoter("jon" , "james" , 988458810), new XSClubPromoter("jon" , "james" , 96568810), new XSClubPromoter("jon" , "james" , 878658810)};

            foreach(var Promoter in promoters)
            {
                Promoter.promoter();
            }

             List<Writer> writer = new List<Writer>()   {new BookWriter("jon" , "james"), new BookWriter("jon" , "james"), new BookWriter("jon" , "james" )};

             foreach(var Writer in writer)
            {
                Writer.writer();
            }

              List<IBodyBuilder> Builder = new List<IBodyBuilder>()   {new XSClubPromoter("jon" , "james" , 988458810), new XSClubPromoter("jon" , "james" , 96568810), new XSClubPromoter("jon" , "james" , 878658810)};
             foreach(var IBodyBuilder in Builder)
            {
                IBodyBuilder.WorkOut();
            }

               List<Ivlooger> vlooger = new List<Ivlooger>()   {new XSClubPromoter("jon" , "james" , 988458810), new BookWriter("jon" , "james")};
            foreach(var Ivlooger in vlooger)
            {
                Ivlooger.vlog();
            }
           
        }
    }
}