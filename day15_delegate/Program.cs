
delegate double delexpense();
delegate int delstudy();
delegate string delhobby();
delegate string delsubject();
delegate void delplay(string n);
class person
{
   public double expense()
    {
        return 200.75;
    }

    public int study()
    {
        return 2;
    }
     
    public string hobby()
    {
        return "coding";
    }
    public string subject()
    {
        return "oops";
    }

    public void address(string n)
    {
        Console.WriteLine("noida");
    }

} 

class friend
{
    public static void Main()
    {
       person obj= new person();

        delexpense mydel = new delexpense(obj.expense);
        var temp = mydel();
        Console.WriteLine(temp);

        delstudy mydele= new delstudy(obj.study);
        var temp2 = mydele();
        Console.WriteLine(temp2);

        delhobby mydel1 =new delhobby(obj.hobby);
        var temp3 = mydel1();
        Console.WriteLine(temp3);

        //delplay mydel2 = new delplay(string n);
        delplay obj2 = new delplay(obj.address);
        obj2(" ");
            


    }
}