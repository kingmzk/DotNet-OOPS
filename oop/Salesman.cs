using System;

public abstract class Salesman
{   
    private string _firname;
    private string _lastname;

    public string Fullname
    {
        get
        {
          return string.Format("{0} {1}",this._firname,this._lastname);
        }
    }
    public Salesman(String firstname , String lastname)
    {
        this._firname = firstname;
        this._lastname = lastname;
    }

    public abstract void Sell();
}