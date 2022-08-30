namespace datas_ex;
public class Class1
{
    public static void Main(string[] args)
    {
      
      var date = new DateTime(2022, 10, 2, 8, 35, 0);
      var dateOnly = date.Date;
      Console.WriteLine(dateOnly.ToString());

      var today = DateTime.Now;
      var duration = new TimeSpan(36, 0, 0, 0);
      var answer = today.Add(duration);

      System.Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
      System.Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
    

      DateTime date1 = new DateTime(2010, 9, 1, 5, 0, 0);
      DateTime date2 = new DateTime(2022, 8, 10, 12, 0, 0);

      int result = DateTime.Compare(date1, date2);
      string relationship;

      if (result < 0) relationship = "é anterior à";
      else if (result == 0) relationship = "è o mesmo que";
      else relationship = "è posterior à";

      // nao sei o que é
      // Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

              Console.Write(new DateTime());

    }
}
