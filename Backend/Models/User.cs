
public abstract class User
{
    public int id { get; set; }
    public string uname { get; set; }
    public string ustudentemail { get; set; }
    //encap
    private string password;
    public void SetPassworrd(string pwd) => password = pwd;
    public bool ValidatePass(string input) => password == input;
    
}
