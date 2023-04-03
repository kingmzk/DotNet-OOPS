
using System;
public class RetailSales : Salesman
{
    public RetailSales(string firstname, string lastname) : base(firstname, lastname)
    {
    }

    public override void Sell()
    {
         Console.WriteLine("hi my name is {0} . I would recommend you to buy this Pen!",this.Fullname);
    }
}