namespace manipulate_ex;
public class Class1
{
    public static void Main(string[] args)
    {
      var res = ValidateName("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Luiz");
        Console.Write(res);
    }
    public static bool ValidateName(string selectedPeople, string name) 
    {
        if(name == null || name == "") 
            throw new ArgumentException("O campo nome está vazio");
        string[] selectedPeopleList = selectedPeople.Split(';');
        bool WasApproved = selectedPeopleList.Contains(name);
        Console.Write(WasApproved);
        return WasApproved;
    }
}
