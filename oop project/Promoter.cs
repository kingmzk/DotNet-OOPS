public abstract class Promoter
{

     private string _fname;
  private string _lname;
  private int _cellphone;

  public string AuthorBio
  {
      get
      {
          return String.Format("my name is {0} {1} {2}",_fname , _lname,_cellphone);
      }
  }
 
 public Promoter(string fname , string lname ,int cellphone)
 {
     this._fname = fname;
     this._lname = lname;
     this._cellphone = cellphone;

 }
    public void promoter()
    {
        this.ShareWithInnerCircle();
        this.UsePaidAdd();
    }

    protected abstract void ShareWithInnerCircle();

    protected abstract void UsePaidAdd();

}