using System;
public abstract class Writer : Ivlooger
{
  private string _fname;
  private string _lname;

  public string AuthorBio
  {
      get
      {
          return String.Format("my name is {0} {1} ",_fname , _lname);
      }
  }
 
 public Writer(string fname , string lname)
 {
     this._fname = fname;
     this._lname = lname;

 }

    public abstract void vlog();
  

    public abstract void writer();
  
}