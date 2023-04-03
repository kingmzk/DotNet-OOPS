using System;

class run
{ 
    static void Main(string[] args)
    {
         CarSalesman steveTheSalesman = new CarSalesman("Steve" , "Rogers");
         Console.WriteLine(steveTheSalesman.Fullname);
         steveTheSalesman.Sell();

        RetailSales  erikTheSalesman = new RetailSales("erik" , "erikson");
        Console.WriteLine(erikTheSalesman.Fullname);
        erikTheSalesman.Sell();
     
    }

}